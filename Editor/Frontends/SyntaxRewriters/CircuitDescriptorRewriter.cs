using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using RRCG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using UnityEngine;

namespace RRCG
{
    public class CircuitDescriptorRewriter : CSharpSyntaxRewriter
    {
        private RRCGSyntaxRewriter rrcgRewriter;

        public CircuitDescriptorRewriter(RRCGSyntaxRewriter rrcgRewriter)
        {
            this.rrcgRewriter = rrcgRewriter;
        }

        //
        // Class translation
        //

        public SyntaxNode VisitClassDeclarationRoot(ClassDeclarationSyntax node)
        {
            return base.VisitClassDeclaration(node);
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

            if (node.Modifiers.Any(t => t.Kind() == SyntaxKind.UnsafeKeyword))
                return node.WithModifiers(new SyntaxTokenList(node.Modifiers.Where(t => t.Kind() != SyntaxKind.UnsafeKeyword)));

            var method = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node);

            var methodName = method.Identifier.ToString();

            var isVoid = method.ReturnType.ToString() == "void";
            var hasParameters = method.ParameterList.Parameters.Count > 0;

            // Make sure the function has a block body
            if (method.ExpressionBody != null)
            {
                method = method
                    .WithExpressionBody(null)
                    .WithSemicolonToken(Token(SyntaxKind.None))
                    .WithBody(
                       isVoid ?
                            Block(ExpressionStatement(method.ExpressionBody.Expression)):
                            // The return needs to be applied already translated here, as to not invalidate the semantic model further down
                            Block(ValueReturnStatement(method.ExpressionBody.Expression))
                );
            }

            var statements = WrapFunctionStatements(method.Body.Statements, method.ReturnType.ToString() == "void");

            // special functions
            var isEventFunction = method.AttributeLists.Any(list => list.Attributes.Any(attr => attr.Name.ToString() == "EventFunction"));
            var isSharedPropertyFunction = method.AttributeLists.Any(list => list.Attributes.Any(attr => attr.Name.ToString() == "SharedProperty"));


            if (isEventFunction)
            {
                ExpressionSyntax identifier = SyntaxFactory.IdentifierName("__DispatchEventFunction");


                if (!isVoid || hasParameters)
                {
                    var genericParams = new List<TypeSyntax>();

                    if (!isVoid) genericParams.Add(method.ReturnType);
                    foreach (var param in method.ParameterList.Parameters) genericParams.Add(param.Type);

                    identifier = SyntaxFactory.GenericName("__DispatchEventFunction").WithTypeArgumentList(SyntaxUtils.TypeArgumentList(genericParams.ToArray()));
                }


                var invocation = SyntaxFactory.InvocationExpression(identifier).WithArgumentList(
                        SyntaxUtils.ArgumentList(
                            new ExpressionSyntax[]
                            {
                                SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(methodName)),
                                SyntaxFactory.AnonymousMethodExpression()
                                            .WithParameterList(method.ParameterList)
                                            .WithBlock(SyntaxFactory.Block(statements))
                            }.Concat(
                                method.ParameterList.Parameters.Select(parameter => SyntaxFactory.IdentifierName(parameter.Identifier.ToString()))
                            ).ToArray()
                        )
                    );

                StatementSyntax statement = isVoid ? SyntaxFactory.ExpressionStatement(invocation) : SyntaxFactory.ReturnStatement(invocation);

                method = method.WithBody(
                    method.Body.WithStatements(SyntaxFactory.SingletonList(statement))
                ).NormalizeWhitespace();
            }
            else if (isSharedPropertyFunction)
            {
                StatementSyntax statement = SyntaxFactory.ReturnStatement(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.GenericName("__DispatchSharedPropertyFunction").WithTypeArgumentList(
                        SyntaxFactory.TypeArgumentList(SyntaxFactory.SingletonSeparatedList<TypeSyntax>(
                            method.ReturnType
                        )))
                    )
                    .WithArgumentList(
                        SyntaxUtils.ArgumentList(
                            SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(methodName)),
                            SyntaxFactory.AnonymousMethodExpression()
                                        .WithParameterList(SyntaxFactory.ParameterList())
                                        .WithBlock(SyntaxFactory.Block(statements))
                        )
                    )
                ).NormalizeWhitespace();

                method = method.WithBody(
                    method.Body.WithStatements(SyntaxFactory.SingletonList(statement))
                );
            }
            else
            {
                method = method.WithBody(
                    method.Body.WithStatements(statements)
                );
            }


            return method;
        }

        public override SyntaxNode VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax method)
        {
            return VisitAnonymousFunction(method, base.VisitSimpleLambdaExpression);
        }
        public override SyntaxNode VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax method)
        {
            return VisitAnonymousFunction(method, base.VisitParenthesizedLambdaExpression);
        }

        public override SyntaxNode VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax method)
        {
            return VisitAnonymousFunction(method, base.VisitAnonymousMethodExpression);
        }

        public T VisitAnonymousFunction<T>(T method, Func<T, SyntaxNode> visitMethod) where T : AnonymousFunctionExpressionSyntax
        {
            SyntaxList<StatementSyntax> statements;
            var visitedMethod = (T)visitMethod(method);

            if (method.Block != null)
            {
                statements = WrapFunctionStatements(
                    visitedMethod.Block.Statements,
                    SyntaxUtils.IsBlockVoid(method.Block)
                );
            }
            else
            {
                // .ExpressionBody and .Block are mutually exclusive -- this function is without a block.
                // We need one for accessibility scopes, so let's create one.
                var semanticModel = rrcgRewriter.GetUpdatedSemanticModel(method.SyntaxTree);
                var needsReturn = !(semanticModel.GetSymbolInfo(method).Symbol as IMethodSymbol).ReturnsVoid;

                statements = SyntaxFactory.SingletonList<StatementSyntax>(
                                needsReturn ? SyntaxFactory.ReturnStatement(visitedMethod.ExpressionBody)
                                            : SyntaxFactory.ExpressionStatement(visitedMethod.ExpressionBody)
                                );

                statements = WrapStatementsInAccessibilityScope(statements, false);
            }

            return (T)visitedMethod.WithBody(
                SyntaxFactory.Block(statements)
            );
        }

        public SyntaxList<StatementSyntax> WrapFunctionStatements(SyntaxList<StatementSyntax> statements, bool isVoid)
        {
            if (!isVoid) statements = statements.Insert(0, SyntaxFactory.ParseStatement("dynamic rrcg_return_data = default;"));
            statements = statements.Insert(0, SyntaxFactory.ParseStatement("ExecFlow rrcg_return_flow = new ExecFlow();"));

            statements = statements.Add(SyntaxFactory.ParseStatement("ExecFlow.current.Merge(rrcg_return_flow);"));
            if (!isVoid) statements = statements.Add(SyntaxFactory.ParseStatement("return rrcg_return_data;"));

            return statements;
        }

        public BlockSyntax WrapBlockInAccessibilityScope(BlockSyntax block, bool canAccessParent)
        {
            var statements = block.Statements;
            return SyntaxFactory.Block(WrapStatementsInAccessibilityScope(statements, canAccessParent));
        }

        public SyntaxList<StatementSyntax> WrapStatementsInAccessibilityScope(SyntaxList<StatementSyntax> statements, bool canAccessParent)
        {
            statements = statements.Insert(0, SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.IdentifierName("__BeginAccessibilityScope"))
                    .WithArgumentList(
                        SyntaxFactory.ArgumentList(
                            SyntaxFactory.SingletonSeparatedList<ArgumentSyntax>(
                                SyntaxFactory.Argument(
                                    SyntaxFactory.LiteralExpression(
                                        canAccessParent ? SyntaxKind.TrueLiteralExpression : SyntaxKind.FalseLiteralExpression
                                    )))))));

            // Insert end before return
            int insertIndex = statements.Count;
            if (statements[insertIndex - 1].Kind() == SyntaxKind.ReturnStatement)
                insertIndex -= 1;

            return statements.Insert(insertIndex, SyntaxFactory.ParseStatement("__EndAccessibilityScope();"));
        }


        //
        // Method contents
        // 

        public override SyntaxNode VisitBlock(BlockSyntax node)
        {
            bool canAccessParent = false;
            if (node.Parent != null)
                canAccessParent = node.Parent.Kind() != SyntaxKind.MethodDeclaration &&
                                  node.Parent.Kind() != SyntaxKind.AnonymousMethodExpression &&
                                  node.Parent.Kind() != SyntaxKind.ParenthesizedLambdaExpression &&
                                  node.Parent.Kind() != SyntaxKind.SimpleLambdaExpression;

            var newStatements = new SyntaxList<StatementSyntax>(node.Statements.Select(s => (StatementSyntax)Visit(s)));
            return SyntaxFactory.Block(
                        WrapStatementsInAccessibilityScope(newStatements, canAccessParent)
                    );
        }

        public override SyntaxNode VisitUnsafeStatement(UnsafeStatementSyntax node)
        {
            return node.Block;
        }

        public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            if (node.Modifiers.Any(t => t.Kind() == SyntaxKind.UnsafeKeyword))
                return node.WithModifiers(new SyntaxTokenList(node.Modifiers.Where(t => t.Kind() != SyntaxKind.UnsafeKeyword)));

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
            var semanticModel = rrcgRewriter.GetUpdatedSemanticModel(node.SyntaxTree); // original node!
            var symbolInfo = semanticModel.GetSymbolInfo(node);
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
                var semanticModel = rrcgRewriter.GetUpdatedSemanticModel(node.SyntaxTree);
                var symbolInfo = semanticModel.GetSymbolInfo(node);

                // Only rewrite if the symbol is referring to a type
                if (symbolInfo.Symbol is not INamedTypeSymbol) return base.VisitIdentifierName(node);
            }

            switch (node.Identifier.ValueText)
            {
                case "AI":
                case "Vector3":
                case "Quaternion":
                case "TriggerHandle":
                case "WelcomeMat":
                case "StudioObject":
                case "AnalyticsPayload":
                case "Player":
                case "RecRoomObject":
                case "Combatant":
                case "PatrolPoint":
                case "Audio":
                case "AudioPlayer":
                case "Consumable":
                case "RoomKey":
                case "BackgroundObjects":
                case "Color":
                case "Beacon":
                case "Button":
                case "TextScreen":
                case "CollisionData":
                case "Costume":
                case "DestinationRoom":
                case "Die":
                case "RoomDoor":
                case "Emitter":
                case "ExplosionEmitter":
                case "Fog":
                case "HUDElement":
                case "Reward":
                case "GroundVehicle":
                case "GunHandle":
                case "HolotarProjector":
                case "InteractionVolume":
                case "InvisibleCollision":
                case "LaserPointer":
                case "Light":
                case "Piston":
                case "PlayerOutfitSlot":
                case "PlayerWorldUI":
                case "ProjectileLauncher":
                case "RemoteVideoPlayer":
                case "PlayerSpawnPointV2":
                case "Skydome":
                case "Sun":
                case "SunDirection":
                case "Rotator":
                case "Seat":
                case "SFX":
                case "Text":
                case "ToggleButton":
                case "MotionTrail":
                case "TriggerVolume":
                case "VectorComponent":
                case "RoomCurrency":
                case "HUDConstant":
                case "SteeringEngine":
                case "GiftDropShopItem":
                case "ObjectiveMarker":
                case "MeleeZone":
                case "SwingHandle":
                case "RoomLevelHUD":
                case "Touchpad":
                case "AnimationController":
                    return IdentifierName(node.Identifier.ValueText + "Port");
                case "RRCGSource":
                    return IdentifierName("RRCGBuild");
            }

            return base.VisitIdentifierName(node);
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
            return SyntaxFactory.ParseStatement("ExecFlow.current.Clear();");
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
            {
                return ExpressionStatement(
                    InvocationExpression(IdentifierName("__Return"))
                    .WithArgumentList(
                        SyntaxUtils.ArgumentList(
                            IdentifierName("rrcg_return_flow")
                        )
                    )
                );
            }

            return ValueReturnStatement(expression);
        }

        public ExpressionStatementSyntax ValueReturnStatement(ExpressionSyntax expression)
        {
            return ExpressionStatement(
                InvocationExpression(
                    IdentifierName("__Return"))
                .WithArgumentList(
                    ArgumentList(
                        SeparatedList<ArgumentSyntax>(
                            new SyntaxNodeOrToken[]{
                                Argument(
                                    IdentifierName("rrcg_return_flow")),
                                Token(SyntaxKind.CommaToken),
                                Argument(
                                    IdentifierName("rrcg_return_data"))
                                .WithRefOrOutKeyword(
                                    Token(SyntaxKind.OutKeyword)),
                                Token(SyntaxKind.CommaToken),
                                Argument(expression)
                            }
                        )
                    )
                )
            );
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

            var semanticModel = rrcgRewriter.GetUpdatedSemanticModel(node.SyntaxTree);
            var symbolInfo = semanticModel.GetDeclaredSymbol(node.Variables[0]); // TODO: Assuming at least one variable. Is this safe?
            var resolvedType = symbolInfo.GetResolvedType();

            if (resolvedType == null)
            {
                Debug.LogWarning($"Failed to resolve type for var-typed variable declaration: {node}");
                return visited;
            }

            var type = ParseTypeName(resolvedType.ToString());
            var rewrittenType = (TypeSyntax)Visit(type);
            var result = visited.WithType(rewrittenType);
            return result;

        }

        public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            if (node.Initializer is not EqualsValueClauseSyntax equalsValueClause)
                return base.VisitVariableDeclarator(node);

            SimpleNameSyntax invocationName = IdentifierName("__VariableDeclaratorExpression");

            // Attempt to resolve build-realm type for the declaration.
            // Write it as the generic parameter for the call to __VariableDeclaratorExpression
            var semanticModel = rrcgRewriter.GetUpdatedSemanticModel(node.SyntaxTree);
            var symbolInfo = semanticModel.GetDeclaredSymbol(node);

            // Try to grab the type from the symbol
            var resolvedType = symbolInfo.GetResolvedType();

            // If we found it (and correctly resolved it),
            // parse & rewrite the type, then write it as
            // the type assignment for invocation.
            if (resolvedType != null)
            {
                // Not sure if this is the best way to get the syntax node for a type. Some types get over-qualified, but at least they work.
                var type = ParseTypeName(resolvedType.ToString());
                var rewrittenType = (TypeSyntax)Visit(type);

                invocationName = GenericName("__VariableDeclaratorExpression").
                    WithTypeArgumentList(
                        TypeArgumentList(
                            SingletonSeparatedList<TypeSyntax>(
                                rewrittenType
                            )
                        )
                    );
            } else
            {
                Debug.LogWarning($"Failed to determine result type for variable declarator expression: {node}");
            }

            // TODO: We need to move field initializers into their static/instance constructors,
            //       because the setter can't reference the field from within the initializer unless it's static.
            //       We can probably do this as a final pass in VisitClassDeclarationRoot.
            //       Once we do this, we can make the setter argument always exist.

            var argumentList = SyntaxUtils.ArgumentList(
                                   SyntaxUtils.StringLiteral(node.Identifier.ToString()),
                                   ParenthesizedLambdaExpression((ExpressionSyntax)base.Visit(equalsValueClause.Value))
                               );

            if (node.FirstAncestorOrSelf<FieldDeclarationSyntax>((_) => true) == null)
                argumentList = argumentList.AddArguments(
                    Argument(
                        ParenthesizedLambdaExpression()
                            .WithParameterList(
                                ParameterList(
                                    SingletonSeparatedList<ParameterSyntax>(
                                        Parameter(
                                            Identifier("rrcg_setter_value")))))
                            .WithExpressionBody(
                                AssignmentExpression(
                                    SyntaxKind.SimpleAssignmentExpression,
                                    IdentifierName(node.Identifier.ToString()),
                                    IdentifierName("rrcg_setter_value")))));

            return node.WithInitializer(
                equalsValueClause.WithValue(
                    InvocationExpression(invocationName)
                    .WithArgumentList(argumentList)
                )
            );
        }

        public override SyntaxNode VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            var visited = (AssignmentExpressionSyntax)base.VisitAssignmentExpression(node);

            // Check if the left-hand side of the assignment is an identifier (variable).
            if (visited.Left is not IdentifierNameSyntax identifier)
                return visited;

            // Remove comments from the identifier
            identifier = identifier.StripTrivia();

            // Expand +=, -=, etc
            ExpressionSyntax valueExpression = visited.Right.StripTrivia();
            if (SyntaxUtils.AssignmentExpressionToBinaryExpression.TryGetValue(visited.Kind(), out var binaryKind))
                valueExpression = BinaryExpression(binaryKind, identifier, valueExpression);

            return InvocationExpression(
                    IdentifierName("__Assign"))
                .WithArgumentList(
                    ArgumentList(
                        SeparatedList<ArgumentSyntax>(
                            new SyntaxNodeOrToken[]{
                                Argument(SyntaxUtils.StringLiteral(identifier.ToString())),
                                Token(SyntaxKind.CommaToken),
                                Argument(identifier)
                                .WithRefOrOutKeyword(
                                    Token(SyntaxKind.OutKeyword)),
                                Token(SyntaxKind.CommaToken),
                                Argument(
                                    ParenthesizedLambdaExpression()
                                    .WithExpressionBody(
                                        valueExpression))})))
                .WithLeadingTrivia(visited.GetLeadingTrivia())
                .WithTrailingTrivia(visited.GetTrailingTrivia())
                .NormalizeWhitespace();
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
            ExpressionSyntax test = (ExpressionSyntax)Visit(node.Condition);
            StatementSyntax trueStatement = (StatementSyntax)Visit(node.Statement);
            StatementSyntax falseStatement = node.Else != null ? (StatementSyntax)Visit(node.Else.Statement) : null;

            // If true/false statements are blocks, we'll have already
            // wrapped them in an accessibility scope (in VisitBlock).
            // Otherwise we'll do this ourselves

            if (trueStatement is not BlockSyntax trueBlock)
                trueBlock = WrapBlockInAccessibilityScope(SyntaxUtils.WrapInBlock(trueStatement), true);
            if (falseStatement is not BlockSyntax falseBlock)
                falseBlock = WrapBlockInAccessibilityScope(SyntaxUtils.WrapInBlock(falseStatement), true);

            return SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        SyntaxFactory.IdentifierName("ChipBuilder"),
                        SyntaxFactory.IdentifierName("If")))
                .WithArgumentList(
                    SyntaxUtils.ArgumentList(
                        test,
                        ExecDelegate().WithBlock(trueBlock),
                        ExecDelegate().WithBlock(falseBlock)
                 )))
            .NormalizeWhitespace();
        }

        public override SyntaxNode VisitSwitchStatement(SwitchStatementSyntax node)
        {
            ExpressionSyntax test = (ExpressionSyntax)Visit(node.Expression);
            var statements = new SyntaxList<SyntaxNode>();

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
                            test,
                            defaultCaseExpression ?? ExecDelegate(),
                            ObjectCreationExpression(
                                GenericName(
                                    Identifier("Dictionary"))
                                .WithTypeArgumentList(
                                    TypeArgumentList(
                                        SeparatedList<TypeSyntax>(
                                            new SyntaxNodeOrToken[]{
                                                IdentifierName("AnyPort"),
                                                Token(SyntaxKind.CommaToken),
                                                IdentifierName("AlternativeExec")}))))
                                .WithInitializer(
                                    InitializerExpression(
                                        SyntaxKind.CollectionInitializerExpression,
                                        SyntaxUtils.ExpressionList(caseInitializers.ToArray())
                            )))
                        ))
                    );

            // Wrap our statements in an accessibility scope & return
            return SyntaxFactory.Block(
                    WrapStatementsInAccessibilityScope(statements, true)
                ).NormalizeWhitespace();
        }

        public override SyntaxNode VisitWhileStatement(WhileStatementSyntax node)
        {
            ExpressionSyntax test = (ExpressionSyntax)Visit(node.Condition);
            StatementSyntax whileStatement = (StatementSyntax)Visit(node.Statement);

            // Like with If translation -- if the statement is a block,
            // we'll have already wrapped it in an accessibility scope.
            // Otherwise we need to do this here.
            if (whileStatement is not BlockSyntax whileBlock)
                whileBlock = WrapBlockInAccessibilityScope(SyntaxUtils.WrapInBlock(whileStatement), true);

            var whileDelegate = ExecDelegate().WithBlock(whileBlock);

            return SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.IdentifierName("__While"))
                .WithArgumentList(
                    SyntaxFactory.ArgumentList(
                        SyntaxFactory.SeparatedList<ArgumentSyntax>(
                            new SyntaxNodeOrToken[]{
                                SyntaxFactory.Argument(test),
                                SyntaxFactory.Token(SyntaxKind.CommaToken),
                                SyntaxFactory.Argument(whileDelegate)})))).NormalizeWhitespace();
        }

        public override SyntaxNode VisitDoStatement(DoStatementSyntax node)
        {
            ExpressionSyntax test = (ExpressionSyntax)Visit(node.Condition);
            StatementSyntax doWhileStatement = (StatementSyntax)Visit(node.Statement);

            // Like with If translation -- if the statement is a block,
            // we'll have already wrapped it in an accessibility scope.
            // Otherwise we need to do this here.
            if (doWhileStatement is not BlockSyntax doBlock)
                doBlock = WrapBlockInAccessibilityScope(SyntaxUtils.WrapInBlock(doWhileStatement), true);

            var doDelegate = ExecDelegate().WithBlock(doBlock);

            return SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.IdentifierName("__DoWhile"))
                .WithArgumentList(
                    SyntaxFactory.ArgumentList(
                        SyntaxFactory.SeparatedList<ArgumentSyntax>(
                            new SyntaxNodeOrToken[]{
                                SyntaxFactory.Argument(test),
                                SyntaxFactory.Token(SyntaxKind.CommaToken),
                                SyntaxFactory.Argument(doDelegate)})))).NormalizeWhitespace();
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

            SimpleNameSyntax ifValueName = IdentifierName(Identifier("IfValue"));

            // Query the semantic model for the result type of the expression.
            // We'll use the converted type (result type after implicit conversions).
            var semanticModel = rrcgRewriter.GetUpdatedSemanticModel(node.SyntaxTree);
            var typeInfo = semanticModel.GetTypeInfo(node);

            // If we're unable to resolve the type, inform the user but try to let the actual compiler infer the type
            if (typeInfo.ConvertedType is not IErrorTypeSymbol)
            {
                var convertedType = typeInfo.ConvertedType.ToTypeSyntax();
                var typeAssignment = (TypeSyntax)Visit(convertedType);

                ifValueName = GenericName(Identifier("IfValue")).WithTypeArgumentList(SyntaxUtils.TypeArgumentList(typeAssignment));
            }
            else
            {
                Debug.LogWarning($"Unable to determine result type of ternary expression: {node}");
            }

            return InvocationExpression(MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("ChipBuilder"),
                        ifValueName
                ))
                .WithArgumentList(
                    SyntaxUtils.ArgumentList(test, whenTrue, whenFalse)
                );
        }

        //
        // Helpers 
        //

        public AnonymousMethodExpressionSyntax ExecDelegate()
        {
            return SyntaxFactory.AnonymousMethodExpression();
        }
    }
}