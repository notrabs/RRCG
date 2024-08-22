using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using UnityEngine;
using AccessibilityScope = RRCGBuild.AccessibilityScope;

namespace RRCG
{
    public partial class CircuitDescriptorRewriter : CSharpSyntaxRewriter
    {
        private RRCGSyntaxRewriter rrcgRewriter;
        private BuildRealmResolver BuildRealmResolver;
        private MemberVariablesVisitor MemberVariablesVisitor;

        public CircuitDescriptorRewriter(RRCGSyntaxRewriter rrcgRewriter)
        {
            this.rrcgRewriter = rrcgRewriter;
            BuildRealmResolver = new(SemanticModel);
            MemberVariablesVisitor = new(this, SemanticModel, BuildRealmResolver);
        }

        SemanticModel SemanticModel => rrcgRewriter.SemanticModel;

        //
        // Class translation
        //

        public SyntaxNode VisitClassDeclarationRoot(ClassDeclarationSyntax node)
        {
            // First, visit the class without its members
            var visitedClass = ClassDeclaration(VisitList(node.AttributeLists), VisitList(node.Modifiers), VisitToken(node.Keyword), VisitToken(node.Identifier),
                                                (TypeParameterListSyntax)Visit(node.TypeParameterList), (BaseListSyntax)Visit(node.BaseList),
                                                List<TypeParameterConstraintClauseSyntax>(), VisitToken(node.OpenBraceToken), List<MemberDeclarationSyntax>(),
                                                VisitToken(node.CloseBraceToken),  VisitToken(node.SemicolonToken));

            // Then visit the members individually
            var newMembers = new SyntaxList<MemberDeclarationSyntax>();
            foreach (var member in node.Members)
            {
                // If it's a field, we could have member variables
                if (member is FieldDeclarationSyntax field &&
                    MemberVariablesVisitor.VisitPotentialMemberVariable(field) is List<MemberDeclarationSyntax> fieldMembers)
                {
                    newMembers = newMembers.AddRange(fieldMembers);
                    continue;
                }

                // Same thing for properties..
                if (member is PropertyDeclarationSyntax property &&
                    MemberVariablesVisitor.VisitPotentialMemberVariable(property) is List<MemberDeclarationSyntax> propMembers)
                {
                    newMembers = newMembers.AddRange(propMembers);
                    continue;
                }

                // Otherwise, just visit ordinarily.
                newMembers = newMembers.Add((MemberDeclarationSyntax)base.Visit(member));
            }

            // Construct final visited class
            var visited = visitedClass.WithMembers(newMembers);

            // Makes sure generic types in RRCG classes are constrained to port types in build realm
            if (node.TypeParameterList != null)
            {
                visited = visited.WithConstraintClauses(
                    SyntaxUtils.TypeParameterConstraintList(
                        node.TypeParameterList.Parameters.Select(
                            p => SyntaxUtils.TypeParameterConstraintClause(IdentifierName(p.Identifier.Text), TypeConstraint(IdentifierName("AnyPort")), ConstructorConstraint())
                        ).ToArray()
                    )
                );
            }

            return visited;
        }

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            return rrcgRewriter.VisitClassDeclaration(node);
        }

        public override SyntaxNode VisitSimpleBaseType(SimpleBaseTypeSyntax node)
        {
            // Attempt to resolve an existing build-realm type (CircuitBuilder/CircuitLibraryBuilder),
            // but fallback to rewriting the namespace if that fails.
            var symbol = SemanticModel.GetSymbolInfo(node.Type).Symbol as ITypeSymbol;
            return SimpleBaseType(BuildRealmResolver.ResolveOrRewriteBuildRealmType(symbol));
        }

        //
        // Methods and Functions
        // 
        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.Identifier.Text.Equals("BuildCircuitGraph")) return node;

            if (node.Modifiers.Any(SyntaxKind.UnsafeKeyword))
                return node;

            // Visit the method signature seperately from its body.
            // We do this to avoid VisitBlock & insert our own AccessibilityScope.
            var method = MethodDeclaration(VisitList(node.AttributeLists), VisitList(node.Modifiers), (TypeSyntax)Visit(node.ReturnType),
                            (ExplicitInterfaceSpecifierSyntax)Visit(node.ExplicitInterfaceSpecifier), VisitToken(node.Identifier),
                            (TypeParameterListSyntax?)Visit(node.TypeParameterList), (ParameterListSyntax)Visit(node.ParameterList),
                            List<TypeParameterConstraintClauseSyntax>(), null, null, MissingToken(SyntaxKind.SemicolonToken));

            var methodName = method.Identifier.ToString();
            var isVoid = method.ReturnType.ToString() == "void";
            var hasParameters = method.ParameterList.Parameters.Count > 0;
            var buildReturnType = method.ReturnType;

            // Make sure generic methods in RRCG classes are constrained to port types in build realm
            if (node.TypeParameterList != null)
            {
                method = method.WithConstraintClauses(
                    SyntaxUtils.TypeParameterConstraintList(
                        node.TypeParameterList.Parameters.Select(
                            p => SyntaxUtils.TypeParameterConstraintClause(IdentifierName(p.Identifier.Text), TypeConstraint(IdentifierName("AnyPort")), ConstructorConstraint())
                        ).ToArray()
                    )
                );
            }

            // Visit method statements
            // ExpressionBody & Body are mutually exclusive.
            var statements = node.Body != null
                                ? VisitList(node.Body.Statements)
                                : SingletonList<StatementSyntax>(isVoid ? ExpressionStatement((ExpressionSyntax)Visit(node.ExpressionBody.Expression))
                                                                        : ValueReturnStatement((ExpressionSyntax)Visit(node.ExpressionBody.Expression), method.ReturnType));


            // Declare parameters as as variables
            // Here we pass the original method's parameters,
            // as the semantic model is used in this operation
            statements = statements.InsertRange(0, VariableDeclaratorsFromParameters(node.ParameterList.Parameters.ToArray()));

            // Fixup default values in parameters
            // Apply the new parameters immediately, but not the coalescers.
            // We need to handle these differently for the special methods.
            var defaultValuesFixup = DefaultValuesToCoalescers(method.ParameterList.Parameters.ToArray());
            method = method.WithParameterList(SyntaxUtils.ParameterList(defaultValuesFixup.Parameters));

            // Wrap in accessibility & return scope
            statements = WrapStatementsInAccessibilityScope(statements, AccessibilityScope.Kind.MethodRoot);
            statements = WrapStatementsInReturnScope(statements, methodName, buildReturnType);

            var methodSymbol = SemanticModel.GetDeclaredSymbol(node);
            var containingType = methodSymbol.ContainingType;
            var isStatic = methodSymbol.IsStatic;

            // special functions
            var methodAttributes = methodSymbol.GetAttributes();
            var isEventFunction = methodAttributes.Any(a => a.AttributeClass == BuildRealmResolver.EventFunctionAttribute);
            var isSharedPropertyFunction = methodAttributes.Any(a => a.AttributeClass == BuildRealmResolver.SharedPropertyAttribute);

            // Build "owner" expression for call to DispatchEventFunction/DispatchSharedProperty.
            // If the method is an instance method, we want to pass "this",
            // so that the instance "owns" that dispatched copy.
            //
            // If the method is static, we instead want to pass the containing type,
            // so that the type itself becomes the owner of the dispatched copy.
            ExpressionSyntax ownerExpression = null;
            if (isEventFunction || isSharedPropertyFunction)
            {
                ownerExpression = ThisExpression();

                if (isStatic)
                {
                    if (containingType == null)
                        throw new Exception($"Static {(isEventFunction ? "EventFunction" : "SharedProperty")} methods must have a valid containing type!");

                    // Rewrite the containing type, such that it points into the RRCGBuild namespace
                    ownerExpression = TypeOfExpression(BuildRealmResolver.RewriteBuildRealmNamespace(containingType));
                }
            }

            if (isEventFunction)
            {
                // Build name syntax for invocation.
                SimpleNameSyntax invocationName = IdentifierName("DispatchEventFunction");

                if (!isVoid || hasParameters)
                {
                    var genericParams = new List<TypeSyntax>();

                    if (!isVoid) genericParams.Add(method.ReturnType);
                    foreach (var param in method.ParameterList.Parameters) genericParams.Add(param.Type);

                    invocationName = GenericName("DispatchEventFunction")
                                        .WithTypeArgumentList(
                                            SyntaxUtils.TypeArgumentList(genericParams.ToArray()));
                }

                // Build invocation
                var invocation = InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            IdentifierName("SpecialMethodsDispatcher"),
                                            IdentifierName("current")),
                                        invocationName))
                                .WithArgumentList(
                                    SyntaxUtils.ArgumentList(
                                        new ExpressionSyntax[]
                                        {
                                            ownerExpression,
                                            LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(methodName)),
                                            AnonymousMethodExpression()
                                                        .WithParameterList(
                                                            SyntaxUtils.ParameterList(
                                                                method.ParameterList.Parameters.Select(p => p.WithDefault(null)).ToArray()))
                                                        .WithBlock(Block(statements))   
                                        }.Concat(
                                            method.ParameterList.Parameters.Select(parameter => IdentifierName(parameter.Identifier.ToString()))
                                        ).ToArray()));

                // Add default value coalescers before invocation
                var eventFunctionStatements = SingletonList<StatementSyntax>(isVoid ? SyntaxFactory.ExpressionStatement(invocation) : SyntaxFactory.ReturnStatement(invocation));
                eventFunctionStatements = eventFunctionStatements.InsertRange(0, defaultValuesFixup.Coalescers);

                method = method.WithBody(Block(eventFunctionStatements)).NormalizeWhitespace();
            }
            else if (isSharedPropertyFunction)
            {
                if (isVoid) throw new Exception($"SharedProperty functions must have a non-void return type: {methodName}");

                StatementSyntax statement = ReturnStatement(
                    InvocationExpression(
                        MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                IdentifierName("SpecialMethodsDispatcher"),
                                IdentifierName("current")),
                            GenericName("DispatchSharedPropertyFunction")
                                .WithTypeArgumentList(
                                    TypeArgumentList(
                                        SingletonSeparatedList<TypeSyntax>(
                                            method.ReturnType)))))
                    .WithArgumentList(
                        SyntaxUtils.ArgumentList(
                            ownerExpression,
                            AnonymousMethodExpression()
                                .WithParameterList(ParameterList())
                                .WithBlock(Block(statements))))).NormalizeWhitespace();

                // Add default value coalescers before invocation
                // Although it probably doesn't matter where we do it
                // for shared properties, as the inputs are only connected once.
                var sharedPropertyStatements = SingletonList(statement).InsertRange(0, defaultValuesFixup.Coalescers);
                method = method.WithBody(Block(sharedPropertyStatements)).NormalizeWhitespace();
            }
            else
            {
                // Normal method
                // Insert default value coalescers as normal.
                method = method.WithBody(
                    Block(statements.InsertRange(0, defaultValuesFixup.Coalescers)));
            }


            return method;
        }

        public override SyntaxNode VisitAccessorDeclaration(AccessorDeclarationSyntax node)
        {
            // This method assumes the accessor is part of a property declaration
            var visited = (AccessorDeclarationSyntax)base.VisitAccessorDeclaration(node);
            if (node.Parent is not AccessorListSyntax accessorList ||
                accessorList.Parent is not PropertyDeclarationSyntax property)
                return visited;

            // Do not rewrite if the property has the unsafe keyword
            if (property.Modifiers.Any(SyntaxKind.UnsafeKeyword))
                return node;

            var isGetter = visited.Kind() == SyntaxKind.GetAccessorDeclaration;
            var typeSymbol = SemanticModel.GetSymbolInfo(property.Type).Symbol as ITypeSymbol;
            var buildType = BuildRealmResolver.ResolveOrRewriteBuildRealmType(typeSymbol);

            // If the accessor has no functional body,
            // we don't need to do anything more.
            if (node.Body == null && node.ExpressionBody == null)
                return visited;

            // Otherwise, collect & visit statements
            // We do this so we can insert our own accessibility scope
            // with the correct AccessibilityScope kind..
            var visitedStatements = node.Body != null
                                        ? VisitList(node.Body.Statements)
                                        : SingletonList<StatementSyntax>(isGetter ? ValueReturnStatement((ExpressionSyntax)Visit(node.ExpressionBody.Expression), buildType)
                                                                                  : ExpressionStatement((ExpressionSyntax)Visit(node.ExpressionBody.Expression)));
            // Wrap in accessibility scope
            visitedStatements = WrapStatementsInAccessibilityScope(visitedStatements, AccessibilityScope.Kind.MethodRoot);

            // Wrap in return scope (for getters)
            if (isGetter)
            {
                var name = $"{property.Identifier}_get";
                visitedStatements = WrapStatementsInReturnScope(visitedStatements, name, buildType);
            }

            // Finally return the visited accessor,
            // with a new block body from our statements
            return visited.WithExpressionBody(null)
                        .WithSemicolonToken(MissingToken(SyntaxKind.SemicolonToken))
                        .WithBody(Block(visitedStatements));
        }

        public override SyntaxNode VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax method)
        {
            var visitedSignature = SimpleLambdaExpression(VisitToken(method.AsyncKeyword), (ParameterSyntax)Visit(method.Parameter),
                                                          VisitToken(method.ArrowToken), null, null);
            return VisitAnonymousFunction(method, visitedSignature, "SimpleLambda", method.Parameter);
        }

        public override SyntaxNode VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax method)
        {
            var visitedSignature = ParenthesizedLambdaExpression(VisitToken(method.AsyncKeyword), (ParameterListSyntax)Visit(method.ParameterList),
                                                                 VisitToken(method.ArrowToken), null, null);
            return VisitAnonymousFunction(method, visitedSignature, "ParenthesizedLambda", method.ParameterList.Parameters.ToArray());
        }

        public override SyntaxNode VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax method)
        {
            var visitedSignature = AnonymousMethodExpression(VisitToken(method.AsyncKeyword), VisitToken(method.DelegateKeyword),
                                                             (ParameterListSyntax)Visit(method.ParameterList), Block(), null);
            return VisitAnonymousFunction(method, visitedSignature, "AnonymousMethod", method.ParameterList.Parameters.ToArray());
        }

        public T VisitAnonymousFunction<T>(T method, T visitedSignature, string methodName, params ParameterSyntax[] unvisitedParameters) where T : AnonymousFunctionExpressionSyntax
        {
            // We need to know the return type.
            // Use of the Semantic Model seems to be very consistent now,
            // so this should really only fail in dire circumstances.
            var methodSymbolInfo = SemanticModel.GetSymbolInfo(method);
            if (methodSymbolInfo.Symbol is not IMethodSymbol methodSymbol)
                throw new Exception($"Failed to resolve method symbol for anonymous function: {method}");

            var returnType = methodSymbol.ReturnType;
            var isVoid = returnType.SpecialType == SpecialType.System_Void;
            var buildReturnType = BuildRealmResolver.ResolveOrRewriteBuildRealmType(returnType);

            // Grab & visit statements from the original method.
            // We do this so we can avoid VisitBlock & insert our own accessibility scope.
            var statements = method.Block != null
                                ? VisitList(method.Block.Statements)
                                : SingletonList<StatementSyntax>(isVoid ? ExpressionStatement((ExpressionSyntax)Visit(method.ExpressionBody))
                                                                        : ValueReturnStatement((ExpressionSyntax)Visit(method.ExpressionBody), buildReturnType));

            // Now we can declare method parameters as variables for the root accessibility scope.
            statements = statements.InsertRange(0, VariableDeclaratorsFromParameters(unvisitedParameters));

            // Wrap the statements in an accessibility & return scope
            statements = WrapStatementsInAccessibilityScope(statements, AccessibilityScope.Kind.MethodRoot);
            statements = WrapStatementsInReturnScope(statements, methodName, buildReturnType);

            // Finally return the method with the new statements
            return (T)visitedSignature.WithBody(Block(statements));
        }

        /// <summary>
        /// Creates calls to __VariableDeclaratorExpression based on a set of method parameters,
        /// so they are declared in the accessibility scope. You should pass unvisited parameters.
        /// </summary>
        public SyntaxList<StatementSyntax> VariableDeclaratorsFromParameters(params ParameterSyntax[] parameters)
        {
            var invocations = new SyntaxList<StatementSyntax>();
            foreach (var parameter in parameters)
            {
                // Skip if the parameter has the ref or out keyword. We don't support this currently, the safe option is to skip.
                if (parameter.Modifiers.Any(m => m.Kind() == SyntaxKind.RefKeyword || m.Kind() == SyntaxKind.OutKeyword)) continue;

                // Skip discarded parameters
                var parameterSymbol = SemanticModel.GetDeclaredSymbol(parameter);
                if (parameterSymbol.IsDiscard) continue;

                var buildType = BuildRealmResolver.ResolveOrRewriteBuildRealmType(parameterSymbol.Type);
                var invocation = VariableDeclaratorExpressionInvocation(parameter.Identifier.ToString(), null, buildType, true);
                invocations = invocations.Add(ExpressionStatement(invocation));
            }

            return invocations;
        }

        /// <summary>
        /// Transforms default value expressions on method parameters into using null-coalescence,
        /// so that they work with the Port types. Pass visited parameters, replace the parameters
        /// with the new parameters from this method, and add the Coalescers to the start of the statements.
        /// </summary>
        public (ParameterSyntax[] Parameters, StatementSyntax[] Coalescers) DefaultValuesToCoalescers(params ParameterSyntax[] parameters)
        {
            // The port types do not support default values with the standard C# syntax.
            // So, we replace the default values with "null!", then use null-coalescence
            // to assign the default value before entering the method.
            var newParameters = new SyntaxList<ParameterSyntax>();
            var coalescers = new SyntaxList<StatementSyntax>();

            foreach (var parameter in parameters)
            {
                // If this parameter does not have a default value,
                // or the default value is already a null/default expression,
                // we'll just pass-through the original parameter.
                var passthroughOriginal = parameter.Default?
                                            .DescendantNodes(_ => true).Select(n => n.Kind())
                                            .Any(k => k == SyntaxKind.NullLiteralExpression ||
                                                      k == SyntaxKind.DefaultExpression) ?? true;

                if (passthroughOriginal)
                {
                    newParameters = newParameters.Add(parameter);
                    continue;
                }

                // Otherwise we need to modify this parameter.
                // Extract the default value expression from the original,
                // then modify the parameter so its default value is "null!"
                var defaultValueExpression = parameter.Default!.Value;
                newParameters = newParameters.Add(parameter.WithDefault(
                                    EqualsValueClause(
                                        PostfixUnaryExpression(
                                            SyntaxKind.SuppressNullableWarningExpression,
                                            LiteralExpression(
                                                SyntaxKind.NullLiteralExpression)))));

                // Then add a "coalescer" statement, that uses
                // null-coalescense to assign the extracted default value.
                coalescers = coalescers.Add(ExpressionStatement(
                                                AssignmentExpression(
                                                    SyntaxKind.CoalesceAssignmentExpression,
                                                    IdentifierName(parameter.Identifier.ToString()),
                                                    defaultValueExpression)));
            }

            return (newParameters.ToArray(), coalescers.ToArray());
        }

        public SyntaxList<StatementSyntax> WrapStatementsInReturnScope(SyntaxList<StatementSyntax> statements, string methodName, TypeSyntax returnType)
        {
            bool isVoid = returnType.ToString() == "void";

            // Create array of tuple element names (in the tuple case)
            ExpressionSyntax tupleElementNames = LiteralExpression(SyntaxKind.NullLiteralExpression);
            if (returnType is TupleTypeSyntax tupleType)
            {
                // Collect element names
                var names = new List<ExpressionSyntax>();

                for (int i = 0; i < tupleType.Elements.Count; i++)
                {
                    var element = tupleType.Elements[i];
                    names.Add(
                        SyntaxUtils.StringLiteral(
                            element.Identifier.Kind() == SyntaxKind.None ? $"value{i}" : element.Identifier.Text
                        ));
                }

                // Create an array constructor with the names
                tupleElementNames = ImplicitArrayCreationExpression(
                    InitializerExpression(
                        SyntaxKind.ArrayInitializerExpression,
                        SyntaxUtils.ExpressionList(names.ToArray())));
            }

            statements = statements.Insert(0, ExpressionStatement(
                InvocationExpression(
                    IdentifierName("__BeginReturnScope"))
                .WithArgumentList(
                    SyntaxUtils.ArgumentList(
                        SyntaxUtils.StringLiteral(methodName),
                        isVoid ? LiteralExpression(SyntaxKind.NullLiteralExpression)
                               : TypeOfExpression(returnType),
                        tupleElementNames))));

            var endInvocation = ParseExpression("__EndReturnScope()");
            StatementSyntax endStatement = isVoid ? ExpressionStatement(endInvocation)
                                                  : ReturnStatement(
                                                      PostfixUnaryExpression(
                                                          SyntaxKind.SuppressNullableWarningExpression,
                                                          endInvocation));

            statements = statements.Add(endStatement);

            return statements;
        }

        public SyntaxList<StatementSyntax> WrapStatementsInAccessibilityScope(SyntaxList<StatementSyntax> statements, AccessibilityScope.Kind scopeKind)
        {
            statements = statements.Insert(0, SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.IdentifierName("__BeginAccessibilityScope"))
                    .WithArgumentList(
                        SyntaxFactory.ArgumentList(
                            SyntaxFactory.SingletonSeparatedList<ArgumentSyntax>(
                                SyntaxFactory.Argument(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            IdentifierName("AccessibilityScope"),
                                            IdentifierName("Kind")),
                                        IdentifierName(scopeKind.ToString("G")))
                                    ))))));

            int insertEndIndex = statements.Count;
            if (statements[insertEndIndex - 1] is ReturnStatementSyntax returnStatement &&
                returnStatement.Expression is ExpressionSyntax returnExp)
            {
                // We want the return expression to be evaluated within the accessibility scope,
                // which means we have to decouple it from the return statement itself.
                // Replace "return <expression>" -> "dynamic __RRCG_RETURN_DATA = <expression>"
                statements = statements.Replace(returnStatement,
                    LocalDeclarationStatement(
                        VariableDeclaration(
                            IdentifierName("dynamic"))
                        .WithVariables(
                            SingletonSeparatedList<VariableDeclaratorSyntax>(
                                VariableDeclarator(
                                    Identifier("__RRCG_RETURN_DATA"))
                                .WithInitializer(
                                    EqualsValueClause(returnExp))))));

                // Then return __RRCG_RETURN_DATA. The __EndAccessibilityScope call will then
                // be inserted between this new return statement and the __RRCG_RETURN_DATA evaluation.
                statements = statements.Insert(insertEndIndex, ReturnStatement(IdentifierName("__RRCG_RETURN_DATA")));
            }

            return statements.Insert(insertEndIndex, SyntaxFactory.ParseStatement("__EndAccessibilityScope();"));
        }


        //
        // Method contents
        // 

        public override SyntaxNode VisitBlock(BlockSyntax node)
        {
            // Trim unreachable statements, and wrap in a general AccessibilityScope.
            var trimmedStatements = TrimUnreachableStatements(node.Statements);
            var newStatements = List(trimmedStatements.Select(s => (StatementSyntax)Visit(s)));
            return Block(WrapStatementsInAccessibilityScope(newStatements, AccessibilityScope.Kind.General));
        }

        public override SyntaxNode VisitUnsafeStatement(UnsafeStatementSyntax node)
        {
            return node.Block;
        }

        public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            // If the field has the unsafe keyword, don't do anything to it.
            if (node.Modifiers.Any(SyntaxKind.UnsafeKeyword))
                return node;
            
            var visitedField = (FieldDeclarationSyntax)base.VisitFieldDeclaration(node);

            // Resolve/rewrite build-realm type, create
            // invocation name for call to __NamedAssignment
            var typeSymbol = SemanticModel.GetSymbolInfo(node.Declaration.Type).Symbol as ITypeSymbol;
            var buildType = BuildRealmResolver.ResolveOrRewriteBuildRealmType(typeSymbol);

            var namedAssignmentName = GenericName("__NamedAssignment")
                .WithTypeArgumentList(SyntaxUtils.TypeArgumentList(buildType));

            // Now we can process the declared variables in the field.
            var newVariables = visitedField.Declaration.Variables.Select(variable =>
            {
                var identifier = variable.Identifier.ToString();

                // Wrap initializer in call to __NamedAssignment,
                // which will preserve the source naming.
                if (variable.Initializer != null)
                    variable = variable.WithInitializer(
                                    EqualsValueClause(
                                        InvocationExpression(namedAssignmentName)
                                        .WithArgumentList(
                                            SyntaxUtils.ArgumentList(
                                                SyntaxUtils.StringLiteral(identifier),
                                                ParenthesizedLambdaExpression()
                                                .WithExpressionBody(variable.Initializer.Value)))));

                return variable;
            });

            // Finally, return the visited field declaration with the new variables.
            return visitedField.WithDeclaration(VariableDeclaration(buildType, SeparatedList(newVariables)));
        }

        public override SyntaxNode VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            // First, visit the node and store the transformed result.
            var visitedNode = (InvocationExpressionSyntax)base.VisitInvocationExpression(node);
            var expression = visitedNode.Expression;

            // Attempt to fixup ommitted type parameters
            var symbolInfo = SemanticModel.GetSymbolInfo(node);
            var methodSymbol = (IMethodSymbol)symbolInfo.Symbol;

            // Bail out if we failed to resolve the method symbol.
            if (methodSymbol == null)
            {
                Debug.LogWarning($"Failed to resolve method symbol for invocation: {node}");
                return visitedNode;
            }

            // Get the method name syntax
            // A bit clunky but we have to do this..
            SimpleNameSyntax methodName;
            var expressionKind = expression.Kind();

            switch (expressionKind)
            {
                case SyntaxKind.GenericName:
                case SyntaxKind.IdentifierName:
                    methodName = (SimpleNameSyntax)expression;
                    break;

                case SyntaxKind.SimpleMemberAccessExpression:
                    methodName = ((MemberAccessExpressionSyntax)expression).Name;
                    break;

                default:
                    return visitedNode;
            }

            // If the method is not a generic method, or the name is already a generic name
            // (meaning type assignments were written manually), bail out
            if (!methodSymbol.IsGenericMethod || methodName is GenericNameSyntax) return visitedNode;

            // Otherwise we need to rewrite the types
            var rewrittenTypes = new SeparatedSyntaxList<TypeSyntax>();
            var resolvedTypeArgs = methodSymbol.TypeArguments;

            foreach (var resolvedType in resolvedTypeArgs)
            {
                // Ensure the type resolved correctly
                if (resolvedType is IErrorTypeSymbol)
                {
                    Debug.LogWarning($"Failed to resolve type assignments for generic invocation expression: {node}");
                    return visitedNode;
                }

                // Resolve/rewrite & store the type
                var buildType = BuildRealmResolver.ResolveOrRewriteBuildRealmType(resolvedType);
                rewrittenTypes = rewrittenTypes.Add(buildType);
            }

            // Apply the type parameters to the expression & return
            var genericName = SyntaxFactory.GenericName(methodName.Identifier, TypeArgumentList(rewrittenTypes));

            switch (expressionKind)
            {
                case SyntaxKind.GenericName:
                case SyntaxKind.IdentifierName:
                    return visitedNode.WithExpression(genericName);

                case SyntaxKind.SimpleMemberAccessExpression:
                    return visitedNode.WithExpression(
                            ((MemberAccessExpressionSyntax)visitedNode.Expression).WithName(genericName)
                        );

                default:
                    return visitedNode;
            }
        }

        //public override SyntaxNode VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        //{
        //    if (node.Expression is IdentifierNameSyntax ins)
        //    {
        //        if (ins.Identifier.Text == "Player")
        //        {
        //            node = node.WithExpression(SyntaxFactory.IdentifierName("PlayerPort"));
        //        }
        //    }

        //    return base.VisitMemberAccessExpression(node);
        //}

        public override SyntaxNode VisitPredefinedType(PredefinedTypeSyntax node)
        {
            // For System.Void, we don't want to do any type resolution. Just pass-through.
            var typeSymbol = SemanticModel.GetSymbolInfo(node).Symbol as ITypeSymbol;
            if (typeSymbol.SpecialType == SpecialType.System_Void)
                return base.VisitPredefinedType(node);

            // For the predefined types, we only want to resolve an existing build-realm type.
            // We don't want to fallback to re-writing it to point into the RRCGBuild namespace.
            if (BuildRealmResolver.ResolveBuildRealmType(typeSymbol) is ITypeSymbol resolved)
                return resolved.ToTypeSyntax();

            Debug.LogWarning($"Unknown predefined type: {node}");
            return base.VisitPredefinedType(node);
        }

        public override SyntaxNode VisitGenericName(GenericNameSyntax node)
            => ResolveOrRewriteIfType(node, base.VisitGenericName);

        public override SyntaxNode VisitQualifiedName(QualifiedNameSyntax node)
            => ResolveOrRewriteIfType(node, base.VisitQualifiedName);

        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
            => ResolveOrRewriteIfType(node, base.VisitIdentifierName);

        // Helper method to prevent logic duplication in VisitGeneric/Qualified/IdentifierName
        SyntaxNode ResolveOrRewriteIfType<T>(T node, Func<T, SyntaxNode> baseVisit) where T : NameSyntax
        {
            // We only want to resolve/rewrite types, so let's check for that first.
            var symbol = SemanticModel.GetSymbolInfo(node).Symbol;
            if (symbol is not ITypeSymbol typeSymbol)
                return baseVisit(node).NormalizeWhitespace();

            // The syntax node is referring to a type.
            // Attempt to resolve it to an existing build-realm type in the compilation.
            // If that fails, rewrite its syntax such that it points into the RRCGBuild namespace.
            return BuildRealmResolver.ResolveOrRewriteBuildRealmType(typeSymbol);
        }

        public override SyntaxNode VisitBreakStatement(BreakStatementSyntax node)
        {
            return SyntaxFactory.ParseStatement("__Break();").NormalizeWhitespace();
        }

        public override SyntaxNode VisitContinueStatement(ContinueStatementSyntax node)
        {
            return SyntaxFactory.ParseStatement("__Continue();").NormalizeWhitespace();
        }

        public override SyntaxNode VisitThrowStatement(ThrowStatementSyntax node)
        {
            return SyntaxFactory.ParseStatement("__Throw();");
        }

        public override SyntaxNode VisitTupleType(TupleTypeSyntax node)
        {
            // Need to forcibly normalize whitespace
            // so that a space is inserted between the type and the name
            // (Playerplayer, intscore) -> (Player player, int score)
            return base.VisitTupleType(node).NormalizeWhitespace();
        }

        public override SyntaxNode VisitGotoStatement(GotoStatementSyntax node)
        {
            var labelName = node.Expression.ToFullString();

            if (node.CaseOrDefaultKeyword.Kind() == SyntaxKind.CaseKeyword)
                labelName = $"rrcg_switch_case_label_{labelName}";

            return SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.IdentifierName("__Goto"))
                .WithArgumentList(
                    SyntaxFactory.ArgumentList(
                        SyntaxFactory.SingletonSeparatedList<ArgumentSyntax>(
                            SyntaxFactory.Argument(
                                SyntaxFactory.LiteralExpression(
                                    SyntaxKind.StringLiteralExpression,
                                    SyntaxFactory.Literal(labelName)
                                )
                            )
                        )
                    )
                )
            );
        }

        public override SyntaxNode VisitLabeledStatement(LabeledStatementSyntax node)
        {
            // Need to rewrite one statement into two: first calling __Label with
            // the label name, then just the enclosed statement.
            // A block is the easiest way to do this, but to avoid scoping issues,
            // we'll give it missing open/close braces. A bit of a hack.
            return SyntaxFactory.Block(
                SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.IdentifierName("__LabelDecl"))
                .WithArgumentList(
                    SyntaxFactory.ArgumentList(
                        SyntaxFactory.SingletonSeparatedList<ArgumentSyntax>(
                            SyntaxFactory.Argument(
                                SyntaxFactory.LiteralExpression(
                                    SyntaxKind.StringLiteralExpression,
                                    SyntaxFactory.Literal(node.Identifier.ValueText))))))),
                (StatementSyntax)Visit(node.Statement))
                .WithOpenBraceToken(SyntaxFactory.MissingToken(SyntaxKind.OpenBraceToken))
                .WithCloseBraceToken(SyntaxFactory.MissingToken(SyntaxKind.CloseBraceToken))
                .NormalizeWhitespace();
        }

        public override SyntaxNode VisitReturnStatement(ReturnStatementSyntax node)
        {
            var expression = (ExpressionSyntax)base.Visit(node.Expression);
            if (expression == null)
                return ParseStatement("__Return();");

            // Attempt to resolve build-realm type to ensure implicit cast to Port types
            var typeSymbol = SemanticModel.GetTypeInfo(node.Expression).ConvertedType;
            if (typeSymbol is not IErrorTypeSymbol)
            {
                var buildType = BuildRealmResolver.ResolveOrRewriteBuildRealmType(typeSymbol);
                return ValueReturnStatement(expression, buildType);
            } else
            {
                Debug.LogWarning($"Failed to determine converted type of expression: {expression}");
                return ValueReturnStatement(expression, null);
            }
        }

        public ExpressionStatementSyntax ValueReturnStatement(ExpressionSyntax expression, TypeSyntax? returnType)
        {
            SimpleNameSyntax invocationName = IdentifierName("__Return");

            if (returnType != null)
                invocationName = GenericName(
                        Identifier("__Return"))
                    .WithTypeArgumentList(
                        SyntaxUtils.TypeArgumentList(returnType));

            return ExpressionStatement(
                InvocationExpression(invocationName)
                .WithArgumentList(
                    SyntaxUtils.ArgumentList(
                        expression)));
        }

        // 
        // Assignments
        // 
        public override SyntaxNode VisitVariableDeclaration(VariableDeclarationSyntax node)
        {
            var visited = (VariableDeclarationSyntax)base.VisitVariableDeclaration(node);

            // Rewrite "var" into correct type (if possible)
            if (!node.Type.IsVar)
                return visited;

            var symbolInfo = SemanticModel.GetDeclaredSymbol(node.Variables[0]); // TODO: Assuming at least one variable. Is this safe?
            if (symbolInfo.GetResolvedType() is ITypeSymbol resolvedType)
            {
                var buildType = BuildRealmResolver.ResolveOrRewriteBuildRealmType(resolvedType);
                return visited.WithType(buildType);
            } else
            {
                Debug.LogWarning($"Failed to resolve type for var-typed variable declaration: {node}");
                return visited;
            }
        }

        public override SyntaxNode VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        {
            var visited = (LocalDeclarationStatementSyntax)base.VisitLocalDeclarationStatement(node);

            // Split declaration from initialization
            // so the getter method in __VariableDeclarationExpression works
            var statements = new SyntaxList<StatementSyntax>();
            visited = visited.ReplaceNodes(visited.Declaration.Variables, (node, _) =>
            {
                // Create initialization statement
                // (the __VariableDeclaratorExpression call would be written
                //  further down, by VisitVariableDeclarator itself)
                var identifier = node.Identifier.ToString();
                statements = statements.Add(
                    ExpressionStatement(
                        AssignmentExpression(
                            SyntaxKind.SimpleAssignmentExpression,
                            IdentifierName(identifier),
                            node.Initializer.Value)));

                // And assign "default!" to the variable as its initializer so
                // the compiler is happy with the getter method.
                // (the correct value will be initialized pretty much immediately, of course)
                return node.WithInitializer(EqualsValueClause(
                                                PostfixUnaryExpression(
                                                    SyntaxKind.SuppressNullableWarningExpression,
                                                    LiteralExpression(
                                                        SyntaxKind.DefaultLiteralExpression,
                                                        Token(SyntaxKind.DefaultKeyword))))).NormalizeWhitespace();
            });

            // Insert new declaration into the start of statements
            statements = statements.Insert(0, visited);

            // We need to rewrite one statement into multiple, so we'll do the block w/ missing braces trick.
            // This is safe because the syntax tree is re-parsed. If that changes this will break!
            // (note: the same trick is done with label declarations)

            return Block(statements)
                   .WithOpenBraceToken(MissingToken(SyntaxKind.OpenBraceToken))
                   .WithCloseBraceToken(MissingToken(SyntaxKind.CloseBraceToken))
                   .NormalizeWhitespace();
        }

        public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            // Ensure declaration is not within a field declaration
            // (we process these seperately in VisitClassDeclarationRoot)
            if (node.FirstAncestorOrSelf<FieldDeclarationSyntax>((_) => true) != null)
                return base.VisitVariableDeclarator(node);

            // Attempt to resolve build-realm type for the declaration.
            // Write it as the generic parameter for the call to __VariableDeclaratorExpression
            var symbolInfo = SemanticModel.GetDeclaredSymbol(node);

            // Try to grab the type from the symbol.
            // If we could resolve it, use it to
            // resolve/rewrite the build-realm type.
            var resolvedType = symbolInfo.GetResolvedType();
            TypeSyntax? buildType = resolvedType != null ? BuildRealmResolver.ResolveOrRewriteBuildRealmType(resolvedType) : null;

            if (buildType == null)
                Debug.LogWarning($"Failed to determine result type for variable declarator expression: {node}");

            var name = node.Identifier.ToString();
            var initializerArg = node.Initializer != null ? (ExpressionSyntax)base.Visit(node.Initializer.Value) : null;
            return node.WithInitializer(EqualsValueClause(VariableDeclaratorExpressionInvocation(name, initializerArg, buildType, true)));
        }

        public override SyntaxNode VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
        {
            // Maybe a __PreIncrement / __PostIncrement pair of methods that take a sign bool?
            // i++ -> __PostIncrement(out i, true)
            // --i -> __PreIncrement(out i, false);
            return base.VisitPostfixUnaryExpression(node);
        }

        public override SyntaxNode VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
        {
            return base.VisitPrefixUnaryExpression(node);
        }

        // 
        // Syntax to Chip transforms
        // 

        public override SyntaxNode VisitIfStatement(IfStatementSyntax node)
        {
            // Build conditional context creation invocation
            var symbols = GetAccessibleSymbolsForConditionalContext(node.SpanStart);
            var createConditional = CreateConditionalContext(symbols, node.Statement, node.Else?.Statement);

            ExpressionSyntax test = (ExpressionSyntax)Visit(node.Condition);
            StatementSyntax trueStatement = (StatementSyntax)Visit(node.Statement);
            StatementSyntax falseStatement = node.Else != null ? (StatementSyntax)Visit(node.Else.Statement) : null;

            // If true/false statements are blocks, we'll have already
            // wrapped them in an accessibility scope (in VisitBlock).
            // Otherwise we'll do this ourselves

            if (trueStatement is not BlockSyntax trueBlock)
                trueBlock = Block(WrapStatementsInAccessibilityScope(SingletonList(trueStatement), AccessibilityScope.Kind.General));
            if (falseStatement is not BlockSyntax falseBlock)
                falseBlock = Block(WrapStatementsInAccessibilityScope(SingletonList(falseStatement), AccessibilityScope.Kind.General));

            return SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(IdentifierName("__If"))
                .WithArgumentList(
                    SyntaxUtils.ArgumentList(
                        createConditional,
                        ParenthesizedLambdaExpression()
                            .WithExpressionBody(test),
                        ExecDelegate().WithBlock(trueBlock),
                        ExecDelegate().WithBlock(falseBlock)
                 )))
            .NormalizeWhitespace();
        }

        public override SyntaxNode VisitSwitchStatement(SwitchStatementSyntax node)
        {
            ExpressionSyntax test = (ExpressionSyntax)Visit(node.Expression);
            var statements = new SyntaxList<SyntaxNode>();

            // Build conditional context creation invocation
            var symbols = GetAccessibleSymbolsForConditionalContext(node.SpanStart);
            var createConditional = CreateConditionalContext(symbols, node.Sections.ToArray());

            // We'll declare the AlternativeExecs for each branch
            // ahead of time, so that we can pass the same reference
            // for multiple branches and avoid duplicate chips.

            List<ExpressionSyntax> caseInitializers = new();
            ExpressionSyntax? defaultCaseExpression = null;

            foreach (var section in node.Sections)
            {
                int sectionIndex = caseInitializers.Count;
                string sectionName = $"rrcg_switch_section_{sectionIndex}";

                // First, visit the statements in this section
                var sectionStatements = new SyntaxList<StatementSyntax>(section.Statements.Select(s => (StatementSyntax)Visit(s)));

                // Then, create and store the key/value initializers for this section,
                // and insert the required label declarations to the section statements.
                foreach (var label in section.Labels)
                {
                    // If this is the default label, add the label declaration "default",
                    // do not create a key/value initializer, store the section delegate identifier
                    string labelName = "default";
                    if (label.Keyword.Text == "default" && defaultCaseExpression == null)
                    {
                        defaultCaseExpression = SyntaxFactory.IdentifierName(sectionName);
                    }
                    else
                    {
                        // Calculate actual label name
                        var caseValue = (ExpressionSyntax)Visit(((CaseSwitchLabelSyntax)label).Value);
                        labelName = caseValue.ToFullString();

                        // Create key/value initializer
                        caseInitializers.Add(SyntaxFactory.InitializerExpression(
                            SyntaxKind.ComplexElementInitializerExpression,
                            SyntaxUtils.ExpressionList(caseValue, SyntaxFactory.IdentifierName(sectionName))));
                    }

                    // Insert label declaration with calculated label name
                    sectionStatements = sectionStatements.Insert(0, SyntaxFactory.ExpressionStatement(
                        SyntaxFactory.InvocationExpression(
                            SyntaxFactory.IdentifierName("__LabelDecl"))
                        .WithArgumentList(
                            SyntaxFactory.ArgumentList(
                                SyntaxFactory.SingletonSeparatedList<ArgumentSyntax>(
                                    SyntaxFactory.Argument(
                                        SyntaxFactory.LiteralExpression(
                                            SyntaxKind.StringLiteralExpression,
                                            SyntaxFactory.Literal($"rrcg_switch_case_label_{labelName}"))))))));
                }

                // Now create an AlternativeExec from our statements
                // and declare it a local variable.
                var sectionFn = ExecDelegate().WithBlock(SyntaxFactory.Block(sectionStatements));

                statements = statements.Add(SyntaxFactory.LocalDeclarationStatement(
                    SyntaxFactory.VariableDeclaration(
                        SyntaxFactory.IdentifierName("AlternativeExec"))
                    .WithVariables(
                        SyntaxFactory.SingletonSeparatedList<VariableDeclaratorSyntax>(
                            SyntaxFactory.VariableDeclarator(
                                SyntaxFactory.Identifier(sectionName))
                            .WithInitializer(
                                SyntaxFactory.EqualsValueClause(
                                    sectionFn))))));
            }

            // Now that all branches have been defined, we can call __Switch.
            statements = statements.Add(ExpressionStatement(
                    InvocationExpression(IdentifierName("__Switch"))
                    .WithArgumentList(
                        SyntaxUtils.ArgumentList(
                            createConditional,
                            ParenthesizedLambdaExpression()
                                .WithExpressionBody(test),
                            defaultCaseExpression ?? ExecDelegate(),
                            ImplicitObjectCreationExpression()
                            .WithInitializer(
                                InitializerExpression(
                                    SyntaxKind.CollectionInitializerExpression,
                                    SyntaxUtils.ExpressionList(caseInitializers.ToArray())
                            )))
                        ))
                    );

            // Wrap our statements in an accessibility scope (for goto scoping) & return
            return SyntaxFactory.Block(
                    WrapStatementsInAccessibilityScope(statements, AccessibilityScope.Kind.General)
                ).NormalizeWhitespace();
        }

        public override SyntaxNode VisitSwitchExpression(SwitchExpressionSyntax node)
        {
            // Create invocation name for call to __SwitchExpression
            SimpleNameSyntax invocationName = IdentifierName(Identifier("__SwitchExpression"));

            // Attempt to determine build-realm result type
            var typeInfo = SemanticModel.GetTypeInfo(node);
            if (typeInfo.ConvertedType is not IErrorTypeSymbol)
            {
                invocationName = GenericName(Identifier("__SwitchExpression"))
                                    .WithTypeArgumentList(
                                        SyntaxUtils.TypeArgumentList(
                                            BuildRealmResolver.ResolveOrRewriteBuildRealmType(typeInfo.ConvertedType)));
            }
            else
            {
                Debug.LogWarning($"Unable to resolve result type for switch expression: {node}");
            }

            // Create dictionary initializer for all the arms
            // (& try to find the default arm)
            var initializers = new List<InitializerExpressionSyntax>();
            bool foundDefault = false;
            ExpressionSyntax defaultExpression = PostfixUnaryExpression(
                                                    SyntaxKind.SuppressNullableWarningExpression,
                                                    LiteralExpression(SyntaxKind.NullLiteralExpression));

            foreach (var arm in node.Arms)
            {
                // Ensure we don't have case guards...
                if (arm.WhenClause != null) throw new Exception("Case guards are not supported in switch expressions!");

                // Is this the default value?
                var armExpression = (ExpressionSyntax)Visit(arm.Expression);
                if (arm.Pattern is DiscardPatternSyntax)
                {
                    if (foundDefault) throw new Exception($"Multiple default values defined for switch expression!");
                    defaultExpression = armExpression;
                    foundDefault = true;
                    continue;
                }

                // Otherwise ensure the pattern is a constant
                if (arm.Pattern is not ConstantPatternSyntax constant)
                    throw new Exception("Switch expression arm patterns must be constants!");

                // Create an initializer for the key & value.
                initializers.Add(InitializerExpression(
                                    SyntaxKind.ComplexElementInitializerExpression,
                                    SyntaxUtils.ExpressionList(
                                        (ExpressionSyntax)Visit(constant.Expression),
                                        ParenthesizedLambdaExpression()
                                            .WithExpressionBody(armExpression))));
            }

            // Now that we have all our cases, let's create the dictionary implicitly:
            var dictionaryInitializer = ImplicitObjectCreationExpression()
                                        .WithInitializer(
                                            InitializerExpression(
                                                SyntaxKind.CollectionInitializerExpression,
                                                SyntaxUtils.ExpressionList(initializers.ToArray())));

            // Finally, we can construct our call to __SwitchExpression.
            return InvocationExpression(invocationName)
                    .WithArgumentList(
                        SyntaxUtils.ArgumentList(
                            (ExpressionSyntax)Visit(node.GoverningExpression),
                            ParenthesizedLambdaExpression()
                                .WithExpressionBody(defaultExpression),
                            dictionaryInitializer));
        }

        public override SyntaxNode VisitWhileStatement(WhileStatementSyntax node)
        {
            return VisitWhileIterator(node, node.Condition, node.Statement, false);
        }

        public override SyntaxNode VisitDoStatement(DoStatementSyntax node)
        {
            return VisitWhileIterator(node, node.Condition, node.Statement, true);
        }

        public SyntaxNode VisitWhileIterator(SyntaxNode node, ExpressionSyntax condition, StatementSyntax bodyStatement, bool buildIfAfterBlock)
        {
            // Build conditional context creation invocation
            var symbols = GetAccessibleSymbolsForConditionalContext(node.SpanStart);
            var createConditional = CreateConditionalContext(symbols, bodyStatement);

            ExpressionSyntax test = (ExpressionSyntax)Visit(condition);
            StatementSyntax whileStatement = (StatementSyntax)Visit(bodyStatement);

            // Like with If translation -- if the statement is a block,
            // we'll have already wrapped it in an accessibility scope.
            // Otherwise we need to do this here.
            if (whileStatement is not BlockSyntax whileBlock)
                whileBlock = Block(WrapStatementsInAccessibilityScope(SingletonList(whileStatement), AccessibilityScope.Kind.General));

            var whileDelegate = ExecDelegate().WithBlock(whileBlock);

            return ExpressionStatement(
                InvocationExpression(
                    IdentifierName("__While"))
                .WithArgumentList(
                    SyntaxUtils.ArgumentList(
                        createConditional,
                        ParenthesizedLambdaExpression()
                            .WithExpressionBody(test),
                        LiteralExpression(
                            buildIfAfterBlock ? SyntaxKind.TrueLiteralExpression : SyntaxKind.FalseLiteralExpression
                        ),
                        whileDelegate
                    ))).NormalizeWhitespace();
        }

        public override SyntaxNode VisitForEachStatement(ForEachStatementSyntax node)
        {
            // Build conditional context creation invocation
            var symbols = GetAccessibleSymbolsForConditionalContext(node.SpanStart);
            var createConditional = CreateConditionalContext(symbols, node.Statement);

            // Visit statement & ensure block w/ accessibility scope
            // If the statement was already a block, VisitBlock would have done that
            var visitedStatement = (StatementSyntax)Visit(node.Statement);
            if (visitedStatement is not BlockSyntax bodyBlock)
                bodyBlock = Block(WrapStatementsInAccessibilityScope(SingletonList(visitedStatement), AccessibilityScope.Kind.General));

            return ExpressionStatement(
                        InvocationExpression(
                            IdentifierName("__ForEach"))
                        .WithArgumentList(
                            SyntaxUtils.ArgumentList(
                                createConditional,
                                node.Expression,
                                ParenthesizedLambdaExpression()
                                .WithParameterList(
                                    ParameterList(
                                        SingletonSeparatedList(
                                            Parameter(node.Identifier))))
                                .WithBlock(bodyBlock))));
        }

        public override SyntaxNode VisitForStatement(ForStatementSyntax node)
        {
            // First, try to determine if this For statement can use the For chip,
            // and get the associated parameters (the index symbol, min/max value expression).
            var canUseForChip = DetermineForStatementOptimization(node, out var indexSymbol, out var minExpression, out var maxExpression);

            // Now, we rewrite the variable declarations into actual locals.
            var statements = new SyntaxList<StatementSyntax>();

            if (node.Declaration != null)
            {
                var typeSymbol = SemanticModel.GetSymbolInfo(node.Declaration.Type).Symbol as ITypeSymbol;
                var buildType = BuildRealmResolver.ResolveOrRewriteBuildRealmType(typeSymbol);

                foreach (var variable in node.Declaration.Variables)
                {
                    var identifier = variable.Identifier.ToString();

                    // Do not declare the index symbol as a local, if we have one
                    var symbol = SemanticModel.GetDeclaredSymbol(variable);
                    if (indexSymbol != null && symbol.Equals(indexSymbol)) continue;

                    // Declare variable
                    statements = statements.Add(LocalDeclarationStatement(
                                                    VariableDeclaration(buildType)
                                                    .WithVariables(
                                                        SingletonSeparatedList<VariableDeclaratorSyntax>(
                                                            VariableDeclarator(identifier)
                                                            .WithInitializer(
                                                                EqualsValueClause(
                                                                    ParseExpression("default!")))))));

                    // Then initialize the variable with a call to __VariableDeclaratorExpression
                    var initializer = variable.Initializer != null ? (ExpressionSyntax)Visit(variable.Initializer.Value) : null;
                    statements = statements.Add(
                        ExpressionStatement(
                            AssignmentExpression(
                                SyntaxKind.SimpleAssignmentExpression,
                                IdentifierName(identifier),
                                VariableDeclaratorExpressionInvocation(identifier, initializer, buildType, true))));
                }
            }

            // Visit loop body & turn into parenthesized lambda
            var visitedStatement = (StatementSyntax)Visit(node.Statement);

            // If the statement was a block, it will have been wrapped in an AccessibilityScope.
            // Otherwise we do this ourselves:
            if (visitedStatement is not BlockSyntax visitedBlock)
                visitedBlock = Block(WrapStatementsInAccessibilityScope(SingletonList(visitedStatement), AccessibilityScope.Kind.General));

            var bodyLambda = ParenthesizedLambdaExpression().WithBlock(visitedBlock);
            if (indexSymbol != null)
                bodyLambda = bodyLambda.WithParameterList(
                                SyntaxUtils.ParameterList(
                                    Parameter(Identifier(indexSymbol.Name.ToString()))));


            // Visit incrementors & turn into parenthesized lambda
            var incrementorsStatements = new SyntaxList<StatementSyntax>();
            foreach (var incrementor in node.Incrementors)
            {
                // If we have an optimizable index symbol, and this incrementor
                // assigns to it, do not include it. In this case we get that value
                // to the loop body as a parameter -- it won't exist here!
                if (indexSymbol != null && SemanticModel.FindAssignedSymbolsRecursive(incrementor).Any(s => s.Equals(indexSymbol)))
                    continue;

                var visitedIncrementor = (ExpressionSyntax)Visit(incrementor);
                incrementorsStatements = incrementorsStatements.Add(ExpressionStatement(visitedIncrementor));
            }

            var incrementorsLambda = ParenthesizedLambdaExpression()
                                     .WithBlock(Block(incrementorsStatements));

            // Construct conditional context invocation,
            // searching the incrementors & statement for assignments
            // to previously accessible & newly-defined symbols.
            var symbols = GetAccessibleSymbolsForConditionalContext(node.SpanStart);
            if (node.Declaration != null)
                symbols = symbols.Concat(node.Declaration.Variables.Select(v => SemanticModel.GetDeclaredSymbol(v)));

            var nodesToSearch = node.Incrementors
                                    .Cast<SyntaxNode>()
                                    .Append(node.Statement)
                                    .ToArray();

            var createConditional = CreateConditionalContext(symbols, nodesToSearch);

            // If we can use the For node, construct call to __OptimizedFor.
            // Otherwise we'll just call __ManualFor.
            if (canUseForChip)
            {
                statements = statements.Add(ExpressionStatement(
                                                InvocationExpression(
                                                    IdentifierName("__OptimizedFor"))
                                                .WithArgumentList(
                                                    SyntaxUtils.ArgumentList(
                                                        createConditional,  
                                                        (ExpressionSyntax)Visit(minExpression),
                                                        (ExpressionSyntax)Visit(maxExpression),
                                                        bodyLambda,
                                                        incrementorsLambda))));
            }
            else
            {
                var conditionLambda = ParenthesizedLambdaExpression()
                                      .WithExpressionBody((ExpressionSyntax)Visit(node.Condition));

                statements = statements.Add(ExpressionStatement(
                                                InvocationExpression(
                                                    IdentifierName("__ManualFor"))
                                                .WithArgumentList(
                                                    SyntaxUtils.ArgumentList(
                                                        createConditional,
                                                        bodyLambda,
                                                        conditionLambda,
                                                        incrementorsLambda))));
            }

            // Finally, wrap statements in an accessibility scope, and return a block.
            return Block(WrapStatementsInAccessibilityScope(statements, AccessibilityScope.Kind.General));
        }

        bool DetermineForStatementOptimization(ForStatementSyntax node, out ILocalSymbol indexSymbol, out ExpressionSyntax minExpression, out ExpressionSyntax maxExpression)
        {
            indexSymbol = null;
            minExpression = null;
            maxExpression = null;

            // This method recognizes these forms:
            // for (int i=MIN; i < MAX; i++)
            // for (int i=MIN; i < MAX; ++i)

            // 1. The condition must be a Less Than expression.
            if (node.Condition is not BinaryExpressionSyntax binaryExpression ||
                binaryExpression.Kind() != SyntaxKind.LessThanExpression)
                return false;

            // 2. The left side of the comparison must be a local variable
            var leftSymbol = SemanticModel.GetSymbolInfo(binaryExpression.Left);
            if (leftSymbol.Symbol is not ILocalSymbol localSymbol)
                return false;

            // 3. The local variable must be declared in the For statement.
            //    It must also be initialized to a value.
            var declaringReferences = localSymbol.DeclaringSyntaxReferences;
            if (declaringReferences.Length != 1) return false;

            var symbolDeclaration = declaringReferences[0].GetSyntax();
            if (symbolDeclaration is not VariableDeclaratorSyntax localDeclaration) return false;
            if (localDeclaration.Parent != node.Declaration) return false;
            if (localDeclaration.Initializer == null) return false;

            // 4. The type of the local variable must be int.
            if (localSymbol.Type.SpecialType != SpecialType.System_Int32) return false;

            // 5. There must not be any assignments to the
            //    local variable within the loop body.
            var assignmentsInBody = SemanticModel.FindAssignedSymbolsRecursive(node.Statement);
            if (assignmentsInBody.Any(s => s.Equals(localSymbol))) return false;

            // 6. The incrementors must contain exactly one
            //    statement that assigns to the local variable.
            //    The statement must increment the variable by exactly 1.

            // Map each incrementor to its assignments..
            var incrementorToAssignments = node.Incrementors.ToDictionary(
                inc => inc,
                inc => SemanticModel.FindAssignedSymbolsRecursive(inc));

            // Find all incrementor/assignment pairs that assign
            // to the local variable..
            var assignsToLocal = incrementorToAssignments
                .Where(kvp => kvp.Value.Any(s => s.Equals(localSymbol)))
                .ToArray();

            // Ensure a count of 1 & grab the corresponding incrementor.
            if (assignsToLocal.Length != 1) return false;
            var incrementor = assignsToLocal[0].Key;

            // Ensure it's incrementing the variable by exactly 1..
            SyntaxKind[] incrementKinds = { SyntaxKind.PreIncrementExpression, SyntaxKind.PostIncrementExpression };

            var incrementorKind = incrementor.Kind();
            if (!incrementKinds.Contains(incrementorKind))
                return false;

            // This for statement seems to follow the forms we can optimize.
            var from = localDeclaration.Initializer.Value;
            var to = binaryExpression.Right;

            indexSymbol = localSymbol;
            minExpression = from;
            maxExpression = to;
            return true;
        }

        public override SyntaxNode VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            string chip = null;
            var negate = false;

            switch (node.Kind())
            {
                case SyntaxKind.GreaterThanExpression:
                    chip = "GreaterThan";
                    break;
                case SyntaxKind.LessThanExpression:
                    chip = "LessThan";
                    break;
                case SyntaxKind.GreaterThanOrEqualExpression:
                    chip = "GreaterOrEqual";
                    break;
                case SyntaxKind.LessThanOrEqualExpression:
                    chip = "LessOrEqual";
                    break;
                case SyntaxKind.EqualsExpression:
                    chip = "Equals";
                    break;
                case SyntaxKind.NotEqualsExpression:
                    chip = "Equals";
                    negate = true;
                    break;
                case SyntaxKind.LogicalAndExpression:
                    chip = "And";
                    break;
                case SyntaxKind.LogicalOrExpression:
                    chip = "Or";
                    break;
                case SyntaxKind.LeftShiftExpression:
                    chip = "BitShiftLeft";
                    break;
                case SyntaxKind.RightShiftExpression:
                    chip = "BitShiftRight";
                    break;
            }

            if (chip != null)
            {
                ExpressionSyntax leftExpression = (ExpressionSyntax)Visit(node.Left);
                ExpressionSyntax rightExpression = (ExpressionSyntax)Visit(node.Right);

                var expression = SyntaxFactory.InvocationExpression(
                            SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.IdentifierName("ChipBuilder"),
                                SyntaxFactory.IdentifierName(chip)))
                        .WithArgumentList(
                            SyntaxUtils.ArgumentList(
                                leftExpression,
                                rightExpression
                            ))
                        .NormalizeWhitespace();

                if (negate)
                {
                    return InvocationExpression(
                            SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.IdentifierName("ChipBuilder"),
                                SyntaxFactory.IdentifierName("Not")))
                        .WithArgumentList(
                            SyntaxUtils.ArgumentList(
                                expression
                            ))
                        .NormalizeWhitespace();
                }

                return expression;
            }

            return base.VisitBinaryExpression(node);
        }

        public override SyntaxNode VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)
        {
            var components = new List<ExpressionSyntax>();

            foreach (var item in node.Contents)
            {
                switch (item.Kind())
                {
                    case SyntaxKind.InterpolatedStringText:
                        var text = ((InterpolatedStringTextSyntax)item).TextToken.ValueText;
                        components.Add(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression,
                                                                       SyntaxFactory.Literal(text)));
                        break;
                    case SyntaxKind.Interpolation:
                        var interp = (InterpolationSyntax)item;
                        if (interp.AlignmentClause != null || interp.FormatClause != null)
                            throw new Exception("String interpolation does not currently support alignment/format clauses");

                        components.Add((ExpressionSyntax)Visit(interp.Expression));
                        break;
                }
            }

            return SyntaxFactory.InvocationExpression(
                    SyntaxFactory.IdentifierName("__StringInterpolation"))
                .WithArgumentList(
                    SyntaxFactory.ArgumentList(
                        SyntaxFactory.SeparatedList<ArgumentSyntax>(
                            components.Select(c => SyntaxFactory.Argument(c))
                        )
                    )
                );
        }

        public override SyntaxNode VisitConditionalExpression(ConditionalExpressionSyntax node)
        {
            ExpressionSyntax test = (ExpressionSyntax)Visit(node.Condition);
            ExpressionSyntax whenTrue = (ExpressionSyntax)Visit(node.WhenTrue);
            ExpressionSyntax whenFalse = (ExpressionSyntax)Visit(node.WhenFalse);

            SimpleNameSyntax invocationName = IdentifierName(Identifier("__Ternary"));

            // Query the semantic model for the result type of the expression.
            // We'll use the converted type (result type after implicit conversions).
            var typeInfo = SemanticModel.GetTypeInfo(node);

            // If we're unable to resolve the type, inform the user but try to let the actual compiler infer the type
            if (typeInfo.ConvertedType is not IErrorTypeSymbol)
            {
                invocationName = GenericName(Identifier("__Ternary"))
                    .WithTypeArgumentList(
                        SyntaxUtils.TypeArgumentList(
                            BuildRealmResolver.ResolveOrRewriteBuildRealmType(typeInfo.ConvertedType)));
            }
            else
            {
                Debug.LogWarning($"Unable to determine result type of ternary expression: {node}");
            }

            return InvocationExpression(invocationName)
                    .WithArgumentList(
                        SyntaxUtils.ArgumentList(test,
                                                 ParenthesizedLambdaExpression()
                                                    .WithExpressionBody(whenTrue),
                                                 ParenthesizedLambdaExpression()
                                                    .WithExpressionBody(whenFalse)));
        }

        //
        // Helpers 
        //

        public AnonymousMethodExpressionSyntax ExecDelegate()
        {
            return SyntaxFactory.AnonymousMethodExpression();
        }

        /// <summary>
        /// Given a set of StatementSyntaxes, remove any which appear beyond
        /// a statement that ends execution flow (return/continue/goto/break/throw).
        /// </summary>
        public IEnumerable<StatementSyntax> TrimUnreachableStatements(IEnumerable<StatementSyntax> statements)
        {
            // NOTE: The SemanticModel provides an AnalyzeControlFlow function that can
            //       be used to easily remove unreachable code in a generalized way.
            //       But this has broader implications, e.g. affecting if statements
            //       with constant condition values, breaking tests.
            //
            //       We may want to use control flow analysis in the future, to solve the
            //       optimizable cases, but for now, this at least solves the problematic ones.
            //       (namely iterators, for example)

            var targetKinds = new[] { SyntaxKind.ReturnStatement, SyntaxKind.ContinueStatement, SyntaxKind.BreakStatement,
                                      SyntaxKind.GotoStatement, SyntaxKind.GotoCaseStatement, SyntaxKind.GotoDefaultStatement,
                                      SyntaxKind.ThrowStatement };

            foreach (var statement in statements)
            {
                yield return statement;
                if (targetKinds.Contains(statement.Kind())) yield break;
            }
        }

        public InvocationExpressionSyntax VariableDeclaratorExpressionInvocation(string identifierName, ExpressionSyntax? initializer, TypeSyntax? resolvedType, bool hasSetter)
        {
            ExpressionSyntax initializerArg = initializer != null ? ParenthesizedLambdaExpression(initializer) : LiteralExpression(SyntaxKind.NullLiteralExpression);
            SimpleNameSyntax invocationName = resolvedType == null ? IdentifierName("__VariableDeclaratorExpression")
                                                                   : GenericName(Identifier("__VariableDeclaratorExpression"))
                                                                         .WithTypeArgumentList(
                                                                             TypeArgumentList(SingletonSeparatedList(resolvedType)));
            ExpressionSyntax setterArg = !hasSetter ? LiteralExpression(SyntaxKind.NullLiteralExpression)
                                                    : ParenthesizedLambdaExpression()
                                                    .WithParameterList(
                                                        ParameterList(
                                                            SingletonSeparatedList<ParameterSyntax>(
                                                                Parameter(
                                                                    Identifier("_RRCG_SETTER_VALUE")))))
                                                    .WithExpressionBody(
                                                        AssignmentExpression(
                                                            SyntaxKind.SimpleAssignmentExpression,
                                                            IdentifierName(identifierName),
                                                            IdentifierName("_RRCG_SETTER_VALUE")));

            return InvocationExpression(invocationName)
                   .WithArgumentList(
                       ArgumentList(
                           SeparatedList<ArgumentSyntax>(
                               new SyntaxNodeOrToken[]{
                                   Argument(SyntaxUtils.StringLiteral(identifierName)),
                                   Token(SyntaxKind.CommaToken),
                                   Argument(initializerArg),
                                   Token(SyntaxKind.CommaToken),
                                   Argument(
                                       ParenthesizedLambdaExpression()
                                           .WithExpressionBody(
                                               PostfixUnaryExpression(
                                                   SyntaxKind.SuppressNullableWarningExpression,
                                                   IdentifierName(identifierName)))),
                                   Token(SyntaxKind.CommaToken),
                                   Argument(setterArg)})))
                   .NormalizeWhitespace();
        }

        // Leaving this seperate for now in case we need to force-promote symbols
        IEnumerable<ISymbol> GetAccessibleSymbolsForConditionalContext(int position)
        {
            return SemanticModel.GetAccessibleSymbols(position, SymbolKind.Local, SymbolKind.Parameter);
        }

        InvocationExpressionSyntax CreateConditionalContext(IEnumerable<ISymbol> accessibleSymbols, params SyntaxNode?[] nodesToSearch)
        {
            // 1. Create arguments list to store our identifier names
            var arguments = new List<ExpressionSyntax>() { };

            var promotedSymbols = new List<ISymbol>();
            foreach (var nodeToSearch in nodesToSearch)
            {
                if (nodeToSearch == null) continue;

                // 2. Find all symbols that are assigned to within this node.
                var assignedSymbols = SemanticModel.FindAssignedSymbolsRecursive(nodeToSearch);

                foreach (var symbol in assignedSymbols)
                {
                    // 3. If the symbol being assigned to is contained within the accessible symbols,
                    // then the variable should be promoted (if we haven't promoted it already)
                    if (!accessibleSymbols.Any(s => s.Equals(symbol))) continue;
                    if (promotedSymbols.Any(s => s.Equals(symbol))) continue;

                    promotedSymbols.Add(symbol);
                    arguments.Add(LiteralExpression(
                                      SyntaxKind.StringLiteralExpression,
                                      Literal(symbol.Name)));
                }
            }

            // 4. Construct call to __ConditionalContext
            return InvocationExpression(
                       IdentifierName("__ConditionalContext"))
                   .WithArgumentList(
                       SyntaxUtils.ArgumentList(arguments.ToArray()));
        }
    }
}