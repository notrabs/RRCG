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
            if (node.Type.ToString() == "CircuitDescriptor") node = node.WithType(ParseTypeName("CircuitBuilder"));
            return base.VisitSimpleBaseType(node);
        }

        //
        // Methods and Functions
        // 

        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.Identifier.Text.Equals("BuildCircuitGraph")) return node;
            var method = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node);

            var methodName = method.Identifier.ToString();

            var statements = WrapFunctionStatements(method.Body.Statements, method.ReturnType.ToString() == "void");

            // special functions
            var isEventFunction = method.AttributeLists.Any(list => list.Attributes.Any(attr => attr.Name.ToString() == "EventFunction"));
            var isSharedPropertyFunction = method.AttributeLists.Any(list => list.Attributes.Any(attr => attr.Name.ToString() == "SharedProperty"));

            var isVoid = method.ReturnType.ToString() == "void";
            var hasParameters = method.ParameterList.Parameters.Count > 0;

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
                method = method.WithBody(method.Body.WithStatements(statements));
            }


            return method;
        }

        public override SyntaxNode VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax method)
        {
            return VisitAnonymousFunction((SimpleLambdaExpressionSyntax)base.VisitSimpleLambdaExpression(method));
        }
        public override SyntaxNode VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax method)
        {
            return VisitAnonymousFunction((ParenthesizedLambdaExpressionSyntax)base.VisitParenthesizedLambdaExpression(method));
        }

        public override SyntaxNode VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax method)
        {
            return VisitAnonymousFunction((AnonymousMethodExpressionSyntax)base.VisitAnonymousMethodExpression(method));
        }

        public T VisitAnonymousFunction<T>(T method) where T : AnonymousFunctionExpressionSyntax
        {
            if (method.ExpressionBody != null) return method;

            var statements = WrapFunctionStatements(
                method.Block.Statements,
                SyntaxUtils.IsBlockVoid(method.Block)
            );

            return (T)method.WithBody(SyntaxFactory.Block(statements));
        }

        public SyntaxList<StatementSyntax> WrapFunctionStatements(SyntaxList<StatementSyntax> statements, bool isVoid)
        {
            if (!isVoid) statements = statements.Insert(0, SyntaxFactory.ParseStatement("dynamic rrcg_return_data = default;"));
            statements = statements.Insert(0, SyntaxFactory.ParseStatement("ExecFlow rrcg_return_flow = new ExecFlow();"));

            statements = statements.Add(SyntaxFactory.ParseStatement("ExecFlow.current.Merge(rrcg_return_flow);"));
            if (!isVoid) statements = statements.Add(SyntaxFactory.ParseStatement("return rrcg_return_data;"));

            return statements;
        }


        //
        // Method contents
        // 

        public override SyntaxNode VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            if (node.Expression is MemberAccessExpressionSyntax ma && ma.Expression is IdentifierNameSyntax ins)
            {
                if (ins.Identifier.Text == "Chips")
                {
                    node = node.WithExpression(ma.WithExpression(SyntaxFactory.IdentifierName("ChipBuilder")));
                }
            }

            return base.VisitInvocationExpression(node);
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

        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
        {
            // Some RRTypes have chips with identical names. This makes sure their functions can still be called.
            if (node.Parent is InvocationExpressionSyntax) return base.VisitIdentifierName(node);

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

        public override SyntaxNode VisitReturnStatement(ReturnStatementSyntax node)
        {
            var expression = (ExpressionSyntax)base.Visit(node.Expression);

            if (expression == null)
            {
                return SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.IdentifierName("__Return"))
                    .WithArgumentList(
                        SyntaxUtils.ArgumentList(
                            (ExpressionSyntax)SyntaxFactory.IdentifierName("rrcg_return_flow")
                        )
                    )
                );
            }

            return SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.IdentifierName("__Return"))
                .WithArgumentList(
                    SyntaxUtils.ArgumentList(
                        (ExpressionSyntax)SyntaxFactory.IdentifierName("rrcg_return_flow"),
                        (ExpressionSyntax)SyntaxFactory.IdentifierName("out rrcg_return_data"),
                        expression
                    )
                )
            );

        }

        // 
        // Assignments
        // 

        public override SyntaxNode VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            //var info = SemanticModel.GetSymbolInfo(node);
            //Debug.Log(info);

            //// Check if the left-hand side of the assignment is an identifier (variable).
            //if (node.Left is IdentifierNameSyntax identifier)
            //{


            //    //// Find the declaration of the identifier in the syntax tree.
            //    //var symbol = SemanticModel.GetSymbolInfo(identifier).Symbol as ILocalSymbol;

            //    //if (symbol != null)
            //    //{
            //    //    // Calculate the scope level difference.
            //    //    int scopeLevelDifference = CalculateScopeLevelDifference(node, symbol);
            //    //    Console.WriteLine($"Scope level difference for variable '{symbol.Name}': {scopeLevelDifference}");
            //    //}
            //}

            return base.VisitAssignmentExpression(node);
        }

        // 
        // Syntax to Chip transforms
        // 

        public override SyntaxNode VisitIfStatement(IfStatementSyntax node)
        {
            ExpressionSyntax test = (ExpressionSyntax)Visit(node.Condition);
            StatementSyntax trueStatement = (StatementSyntax)Visit(node.Statement);
            StatementSyntax falseStatement = node.Else != null ? (StatementSyntax)Visit(node.Else.Statement) : null;

            return SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        SyntaxFactory.IdentifierName("ChipBuilder"),
                        SyntaxFactory.IdentifierName("If")))
                .WithArgumentList(
                    SyntaxUtils.ArgumentList(
                        test,
                        ExecDelegate().WithBlock(
                            SyntaxUtils.WrapInBlock(trueStatement)
                        ),
                        ExecDelegate().WithBlock(
                            SyntaxUtils.WrapInBlock(falseStatement)
                        )
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
            ExpressionSyntax defaultCaseExpression = ExecDelegate();

            foreach (var section in node.Sections)
            {
                int sectionIndex = caseInitializers.Count;
                string sectionName = $"rrcg_switch_section_{sectionIndex}";

                // First, create and store the
                // key/value initializers for this section.
                foreach (var label in section.Labels)
                {
                    if (label.Keyword.Text == "default")
                    {
                        defaultCaseExpression = SyntaxFactory.IdentifierName(sectionName);
                        continue;
                    }

                    var caseValue = (ExpressionSyntax)Visit(((CaseSwitchLabelSyntax)label).Value);

                    caseInitializers.Add(SyntaxFactory.InitializerExpression(
                        SyntaxKind.ComplexElementInitializerExpression,
                        SyntaxUtils.ExpressionList(caseValue, SyntaxFactory.IdentifierName(sectionName))));
                }

                // Now generate the declaration statement for the AlternativeExec
                var sectionFn = ExecDelegate().WithBlock((BlockSyntax)Visit(SyntaxFactory.Block(section.Statements)));

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
                            defaultCaseExpression,
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

            return SyntaxFactory.Block(statements).NormalizeWhitespace();
        }

        public override SyntaxNode VisitWhileStatement(WhileStatementSyntax node)
        {
            ExpressionSyntax test = (ExpressionSyntax)Visit(node.Condition);
            BlockSyntax whileBlock = (BlockSyntax)Visit(node.Statement);

            var statements = new SyntaxList<SyntaxNode>();
            statements = statements.Add(ExpressionStatement(
                InvocationExpression(
                    IdentifierName("__BeginWhileLoop"))
                .WithArgumentList(
                    ArgumentList(
                        SingletonSeparatedList<ArgumentSyntax>(
                            Argument(test))))));

            statements = statements.Add(whileBlock);
            statements = statements.Add(SyntaxFactory.ParseStatement("__EndWhileLoop();"));

            return SyntaxFactory.Block(statements).NormalizeWhitespace();
        }

        public override SyntaxNode VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            string chip = null;
            var negate = false;

            switch (node.Kind())
            {
                case SyntaxKind.AddExpression:
                    chip = "Add";
                    break;
                case SyntaxKind.SubtractExpression:
                    chip = "Subtract";
                    break;
                case SyntaxKind.MultiplyExpression:
                    chip = "Multiply";
                    break;
                case SyntaxKind.DivideExpression:
                    chip = "Divide";
                    break;
                case SyntaxKind.ModuloExpression:
                    chip = "Modulo";
                    break;
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

        //
        // Helpers 
        //

        private int CalculateScopeLevelDifference(SyntaxNode assignmentNode, ISymbol symbol)
        {
            // Walk up the syntax tree to find the declaration of the variable.
            //var currentScope = assignmentNode.Parent;
            //int scopeLevelDifference = 0;

            //while (currentScope != null)
            //{
            //    if (currentScope is BlockSyntax)
            //    {
            //        // Check if the current scope contains the declaration of the variable.
            //        if (symbol.ContainingSymbol.Equals(SemanticModel.GetEnclosingSymbol(currentScope)))
            //        {
            //            return scopeLevelDifference;
            //        }

            //        scopeLevelDifference++;
            //    }

            //    currentScope = currentScope.Parent;
            //}

            throw new Exception("Could not determine level scope difference. Is the variable defined?");
        }

        public AnonymousMethodExpressionSyntax ExecDelegate()
        {
            return SyntaxFactory.AnonymousMethodExpression();
        }

    }
}
