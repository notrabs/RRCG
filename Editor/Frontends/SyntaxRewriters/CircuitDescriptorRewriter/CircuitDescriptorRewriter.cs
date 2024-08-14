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
        private MemberVariablesProcessor memberVariablesProcessor;
        private NamedAssignmentProcessor namedAssignmentProcessor;

        public CircuitDescriptorRewriter(RRCGSyntaxRewriter rrcgRewriter)
        {
            this.rrcgRewriter = rrcgRewriter;
            memberVariablesProcessor = new(this);
            namedAssignmentProcessor = new(this);
        }

        SemanticModel SemanticModel => rrcgRewriter.SemanticModel;

        //
        // Class translation
        //

        public SyntaxNode VisitClassDeclarationRoot(ClassDeclarationSyntax node)
        {
            var visited = (ClassDeclarationSyntax)base.VisitClassDeclaration(node);

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

            // Process class members as necessary

            // Processors consume from allMembers by reference.
            // They return a list of new members, which is merged into newMembers.

            // We do this so that any already-processed members
            // aren't re-processed by other processors.

            var allMembers = visited.Members.ToList();
            var newMembers = new List<MemberDeclarationSyntax>();

            // Process member variables..
            newMembers.AddRange(memberVariablesProcessor.ProcessMemberVariables(allMembers));

            // Process named assignments...
            newMembers.AddRange(namedAssignmentProcessor.ProcessMemberAssignments(allMembers));

            // Now that all the processors are done, merge the new members back into the
            // list of original (surviving..?) members, and return.
            allMembers.AddRange(newMembers);
            return visited.WithMembers(new SyntaxList<MemberDeclarationSyntax>(allMembers));
        }

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            return rrcgRewriter.VisitClassDeclaration(node);
        }

        public override SyntaxNode VisitSimpleBaseType(SimpleBaseTypeSyntax node)
        {
            // Rewriting isn't really necessary. But it helps with Autocomplete when looking for these types.
            var visited = (SimpleBaseTypeSyntax)base.VisitSimpleBaseType(node);

            if (visited.Type.ToString() == "CircuitDescriptor") visited = visited.WithType(ParseTypeName("CircuitBuilder"));
            if (visited.Type.ToString() == "CircuitLibrary") visited = visited.WithType(ParseTypeName("CircuitLibraryBuilder"));
            return visited;
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
                            List<TypeParameterConstraintClauseSyntax>(), Block(), null, MissingToken(SyntaxKind.SemicolonToken));

            var methodName = method.Identifier.ToString();
            var isVoid = method.ReturnType.ToString() == "void";
            var hasParameters = method.ParameterList.Parameters.Count > 0;
            var rewrittenReturnType = method.ReturnType;

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
            (var newParameters, var coalescers) = DefaultValuesToCoalescers(method.ParameterList.Parameters.ToArray());
            method = method.WithParameterList(SyntaxUtils.ParameterList(newParameters));
            statements = statements.InsertRange(0, coalescers);

            // Wrap in accessibility & return scope
            statements = WrapStatementsInAccessibilityScope(statements, AccessibilityScope.Kind.MethodRoot);
            statements = WrapStatementsInReturnScope(statements, methodName, rewrittenReturnType);

            // special functions
            var isEventFunction = method.AttributeLists.Any(list => list.Attributes.Any(attr => attr.Name.ToString() == "EventFunction"));
            var isSharedPropertyFunction = method.AttributeLists.Any(list => list.Attributes.Any(attr => attr.Name.ToString() == "SharedProperty"));

            var methodSymbol = SemanticModel.GetDeclaredSymbol(node);
            var containingType = methodSymbol.ContainingType;
            var isStatic = methodSymbol.IsStatic;

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

                    // Rewrite the type, so that the namespace is translated (if it ends up overqualifying)
                    ownerExpression = TypeOfExpression((TypeSyntax)Visit(containingType.ToTypeSyntax()));
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
                                                        .WithParameterList(method.ParameterList)
                                                        .WithBlock(Block(statements))
                                        }.Concat(
                                            method.ParameterList.Parameters.Select(parameter => IdentifierName(parameter.Identifier.ToString()))
                                        ).ToArray()));

                StatementSyntax statement = isVoid ? SyntaxFactory.ExpressionStatement(invocation) : SyntaxFactory.ReturnStatement(invocation);

                method = method.WithBody(Block(SingletonList(statement))).NormalizeWhitespace();
            }
            else if (isSharedPropertyFunction)
            {
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

                method = method.WithBody(Block(SingletonList(statement)));
            }
            else
            {
                method = method.WithBody(Block(statements));
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
            var rewrittenType = (TypeSyntax)Visit(property.Type);

            // Collect & visit statements
            // We do this so we can insert our own accessibility scope
            // with the correct AccessibilityScope kind..
            //
            // (We could just add the get/set accessor kinds to the switch in VisitBlock,
            //  but the parenting check above would be a little too out-of-place.
            //  Probably cleaner overall to visit manually in these cases..)

            var visitedStatements = new SyntaxList<StatementSyntax>();
            if (node.ExpressionBody != null)
            {
                var visitedExpression = (ExpressionSyntax)Visit(node.ExpressionBody.Expression);
                visitedStatements = visitedStatements.Add(isGetter ? ValueReturnStatement(visitedExpression, rewrittenType)
                                                                   : ExpressionStatement(visitedExpression));
            } else if (node.Body != null)
            {
                visitedStatements = visitedStatements.AddRange(node.Body.Statements.Select(s => (StatementSyntax)Visit(s)));
            } else
            {
                // The accessor has no functional body.
                // We don't need to do anything more.
                return visited;
            }

            // Wrap in accessibility scope
            visitedStatements = WrapStatementsInAccessibilityScope(visitedStatements, AccessibilityScope.Kind.MethodRoot);

            // Wrap in return scope (for getters)
            if (isGetter)
            {
                var name = $"{property.Identifier}_get";
                visitedStatements = WrapStatementsInReturnScope(visitedStatements, name, rewrittenType);
            }

            // Finally return the visited accessor,
            // with a new block body from our statements
            return visited.WithExpressionBody(null)
                        .WithSemicolonToken(MissingToken(SyntaxKind.SemicolonToken))
                        .WithBody(Block(visitedStatements));
        }

        public override SyntaxNode VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax method)
        {
            var visitedMethod = (SimpleLambdaExpressionSyntax)base.VisitSimpleLambdaExpression(method);
            return VisitAnonymousFunction(method, visitedMethod, "SimpleLambda", method.Parameter);
        }
        public override SyntaxNode VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax method)
        {
            var visitedMethod = (ParenthesizedLambdaExpressionSyntax)base.VisitParenthesizedLambdaExpression(method);
            return VisitAnonymousFunction(method, visitedMethod, "ParenthesizedLambda", method.ParameterList.Parameters.ToArray());
        }

        public override SyntaxNode VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax method)
        {
            var visitedMethod = (AnonymousMethodExpressionSyntax)base.VisitAnonymousMethodExpression(method);
            return VisitAnonymousFunction(method, visitedMethod, "AnonymousMethod", method.ParameterList.Parameters.ToArray());
        }

        public T VisitAnonymousFunction<T>(T method, T visitedMethod, string methodName, params ParameterSyntax[] unvisitedParameters) where T : AnonymousFunctionExpressionSyntax
        {
            SyntaxList<StatementSyntax> statements;

            var returnType = (SemanticModel.GetSymbolInfo(method).Symbol as IMethodSymbol).ReturnType.ToTypeSyntax();
            var rewrittenReturnType = (TypeSyntax)Visit(returnType);

            // Grab statements from the block/expression body
            if (method.Block != null)
            {
                statements = visitedMethod.Block.Statements;
            }
            else
            {
                statements = SyntaxFactory.SingletonList<StatementSyntax>(
                                returnType.ToString() == "void" ? SyntaxFactory.ExpressionStatement(visitedMethod.ExpressionBody)
                                                                : ValueReturnStatement(visitedMethod.ExpressionBody, rewrittenReturnType)
                                );
            }

            // Now we can declare method parameters as variables for the root accessibility scope.
            statements = statements.InsertRange(0, VariableDeclaratorsFromParameters(unvisitedParameters));

            // Wrap the statements in an accessibility & return scope
            statements = WrapStatementsInAccessibilityScope(statements, AccessibilityScope.Kind.MethodRoot);
            statements = WrapStatementsInReturnScope(statements, methodName, rewrittenReturnType);

            // Finally return the method with the new statements
            return (T)visitedMethod.WithBody(Block(statements));
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

                var rewrittenType = (TypeSyntax)Visit(parameter.Type);
                var invocation = VariableDeclaratorExpressionInvocation(parameter.Identifier.ToString(), null, rewrittenType, true);
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
            var kind = AccessibilityScope.Kind.General;
            var trimmedStatements = TrimUnreachableStatements(node.Statements);
            var newStatements = new SyntaxList<StatementSyntax>(trimmedStatements.Select(s => (StatementSyntax)Visit(s)));

            switch (node.Parent?.Kind())
            {
                case SyntaxKind.AnonymousMethodExpression:
                case SyntaxKind.ParenthesizedLambdaExpression:
                case SyntaxKind.SimpleLambdaExpression:
                    // In these cases we need to declare parameters as variables
                    // within the method's root accessibility scope. To make things
                    // easier for ourselves, we'll skip inserting one here and leave it
                    // to VisitMethodDeclaration / VisitAnonymousFunction.
                    return Block(newStatements);

            }

            // Otherwise we can wrap it & return.
            return Block(
                        WrapStatementsInAccessibilityScope(newStatements, kind)
                    );
        }

        public override SyntaxNode VisitUnsafeStatement(UnsafeStatementSyntax node)
        {
            return node.Block;
        }

        public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            if (node.Modifiers.Any(SyntaxKind.UnsafeKeyword))
                return node;

            return base.VisitFieldDeclaration(node);
        }

        public override SyntaxNode VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            // First, visit the node and store the transformed result.
            var visitedNode = (InvocationExpressionSyntax)base.VisitInvocationExpression(node);
            var expression = visitedNode.Expression;

            // Rewrite Chips -> ChipBuilder
            if (expression is MemberAccessExpressionSyntax ma && ma.Expression is SimpleNameSyntax ins)
            {
                if (ins.Identifier.Text == "Chips")
                {
                    visitedNode = visitedNode.WithExpression(ma.WithExpression(SyntaxFactory.IdentifierName("ChipBuilder")));
                }
            }

            // Attempt to fixup ommitted type parameters
            var symbolInfo = SemanticModel.GetSymbolInfo(node);
            var methodSymbol = (IMethodSymbol)symbolInfo.Symbol;

            // Bail out if we failed to resolve the method symbol.
            if (methodSymbol == null) return visitedNode;

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
                if (resolvedType.ToString() == "?")
                {
                    Debug.LogWarning($"Failed to resolve type assignments for generic invocation expression: {node}");
                    return visitedNode;
                }

                // Rewrite & store the type
                var typeSyntax = resolvedType.ToTypeSyntax();
                rewrittenTypes = rewrittenTypes.Add((TypeSyntax)Visit(typeSyntax));
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
            switch (node.Keyword.ValueText)
            {
                case "bool":
                    return IdentifierName("BoolPort");
                case "string":
                    return IdentifierName("StringPort");
                case "int":
                    return IdentifierName("IntPort");
                case "float":
                    return IdentifierName("FloatPort");
                case "void":
                    // ignore
                    break;
                default:
                    Debug.Log("unknonw predefined type: " + node.Keyword.ValueText);
                    break;
            }

            return base.VisitPredefinedType(node);
        }

        public override SyntaxNode VisitGenericName(GenericNameSyntax node)
        {
            switch (node.Identifier.ValueText)
            {
                case "List":
                    return ((GenericNameSyntax)base.VisitGenericName(node))
                        .WithIdentifier(Identifier(node.Identifier.ValueText + "Port"));
            }

            return base.VisitGenericName(node);
        }

        public override SyntaxNode VisitQualifiedName(QualifiedNameSyntax node)
        {
            // Makes sure the mapped Unity Types get mapped into their corresponding port types, even if they are fully qualified
            var names = node.ChildNodes().ToArray();

            if (names.Length == 2 && names[0].ToString() == "UnityEngine")
            {
                var unityType = names[1].ToString();

                switch (unityType)
                {
                    case "Vector3":
                    case "Quaternion":
                    case "Color":
                        return IdentifierName(unityType + "Port");
                }
            }
            else if (node.ToString().StartsWith("System.Collections.Generic.List"))
            {
                var listGeneric = (GenericNameSyntax)names[1];
                return VisitGenericName(listGeneric);
            }

            return base.VisitQualifiedName(node);
        }

        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
        {
            // We only want to rewrite types, which requires checking the semantic model.
            // However, there are some places (like visiting variable declarators) where we
            // want to rewrite a type from a node that isn't part of the original compilation.
            // Thankfully we can just check for this, but maybe there's another way?
            var root = node.SyntaxTree.GetRoot();
            if (root is not TypeSyntax)
            {
                var symbolInfo = SemanticModel.GetSymbolInfo(node);

                // Only rewrite if the symbol is referring to a type
                if (symbolInfo.Symbol is not INamedTypeSymbol) return base.VisitIdentifierName(node).NormalizeWhitespace();
            }

            if (RRTypesUtils.ImplemetedRRTypes.Contains(node.Identifier.ValueText))
            {
                return IdentifierName(node.Identifier.ValueText + "Port").NormalizeWhitespace();
            }

            switch (node.Identifier.ValueText)
            {
                case "RRCGSource":
                    return IdentifierName("RRCGBuild");
            }

            return base.VisitIdentifierName(node).NormalizeWhitespace();
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
            TypeSyntax? rewrittenType = null;
            var typeSymbol = SemanticModel.GetTypeInfo(node.Expression).ConvertedType;

            if (typeSymbol.ToString() != "?")
                rewrittenType = (TypeSyntax)Visit(typeSymbol.ToTypeSyntax());
            else
                Debug.LogWarning($"Failed to determine converted type of expression: {expression}");

            return ValueReturnStatement(expression, rewrittenType);
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
            var resolvedType = symbolInfo.GetResolvedType();

            if (resolvedType == null)
            {
                Debug.LogWarning($"Failed to resolve type for var-typed variable declaration: {node}");
                return visited;
            }

            var type = resolvedType.ToTypeSyntax();
            var rewrittenType = (TypeSyntax)Visit(type);
            var result = visited.WithType(rewrittenType);
            return result;

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
            TypeSyntax? finalType = null;
            var symbolInfo = SemanticModel.GetDeclaredSymbol(node);

            // Try to grab the type from the symbol
            var resolvedType = symbolInfo.GetResolvedType();

            // If we found it (and correctly resolved it),
            // parse & rewrite the type, then write it as
            // the type assignment for invocation.
            if (resolvedType != null)
            {
                var type = resolvedType.ToTypeSyntax();
                finalType = (TypeSyntax)Visit(type);
            }
            else
            {
                Debug.LogWarning($"Failed to determine result type for variable declarator expression: {node}");
            }

            var name = node.Identifier.ToString();
            var initializerArg = node.Initializer != null ? (ExpressionSyntax)base.Visit(node.Initializer.Value) : null;
            return node.WithInitializer(EqualsValueClause(VariableDeclaratorExpressionInvocation(name, initializerArg, finalType, true)));
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
                // Re-parse and rewrite, see VisitIdentifierName
                var syntax = typeInfo.ConvertedType.ToTypeSyntax();
                var rewritten = (TypeSyntax)Visit(syntax);
                invocationName = GenericName(Identifier("__SwitchExpression"))
                                    .WithTypeArgumentList(SyntaxUtils.TypeArgumentList(rewritten));
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
                var rewrittenType = (TypeSyntax)Visit(node.Declaration.Type);
                foreach (var variable in node.Declaration.Variables)
                {
                    var identifier = variable.Identifier.ToString();

                    // Do not declare the index symbol as a local, if we have one
                    var symbol = SemanticModel.GetDeclaredSymbol(variable);
                    if (indexSymbol != null && symbol.Equals(indexSymbol)) continue;

                    // Declare variable
                    statements = statements.Add(LocalDeclarationStatement(
                                                    VariableDeclaration(rewrittenType)
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
                                VariableDeclaratorExpressionInvocation(identifier, initializer, rewrittenType, true))));
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
                var convertedType = typeInfo.ConvertedType.ToTypeSyntax();
                var typeAssignment = (TypeSyntax)Visit(convertedType);

                invocationName = GenericName(Identifier("__Ternary")).WithTypeArgumentList(SyntaxUtils.TypeArgumentList(typeAssignment));
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
                                                    .WithExpressionBody(whenFalse))
                    );
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