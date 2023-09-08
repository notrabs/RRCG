using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.Formatting;
using System.Collections.Generic;
using UnityEngine;

namespace RRCG
{
    public class RRCGSytaxRewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitCompilationUnit(CompilationUnitSyntax node)
        {
            if (!node.Usings.Any(u => u.Name.ToString() == "RRCGSource"))
            {
                node.RemoveNode(node.Usings.First(u => u.Name.ToString() == "RRCGSource"), SyntaxRemoveOptions.KeepNoTrivia);
            }

            if (!node.Usings.Any(u => u.Name.ToString() == "RRCGBuild"))
            {
                node = node.AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("RRCGBuild")).WithAdditionalAnnotations(Formatter.Annotation));
            }

            if (!node.Usings.Any(u => u.Name.ToString() == "System.Collections.Generic"))
            {
                node = node.AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic")).WithAdditionalAnnotations(Formatter.Annotation));
            }

            return base.VisitCompilationUnit(node);
        }

        public override SyntaxNode VisitUsingDirective(UsingDirectiveSyntax node)
        {
            if (node.Name.ToString() == "RRCGSource")
            {
                return null;
            }
            return base.VisitUsingDirective(node);
        }

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var replacedName = node.Identifier.Text + "Gen";

            node = node.WithIdentifier(SyntaxFactory.Identifier(replacedName));


            StringBuilder sb = new StringBuilder();

            sb.Append(@"
    public override Context BuildCircuitGraph()
    {

        List<Node> nodes = new List<Node>();
        List<Connection> connections = new List<Connection>();

        Context context = new Context
        {
            Nodes = nodes,
            Connections = connections
        };

        Context.current = context;
        ExecFlow.current = new ExecFlow();

        CircuitGraph();

        return context;
    }");

            // Add the method to the class members
            var method = SyntaxFactory.ParseMemberDeclaration(sb.ToString());
            node = node.AddMembers(method);

            return base.VisitClassDeclaration(node);
        }

        public override SyntaxNode VisitSimpleBaseType(SimpleBaseTypeSyntax node)
        {
            if (node.Type.ToString() == "CircuitDescriptor")
            {
                node = node.WithType(SyntaxFactory.ParseTypeName("CircuitBuilder"));
            }

            return base.VisitSimpleBaseType(node);
        }


        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.Identifier.Text.Equals("BuildCircuitGraph")) return node;
            var method = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node);

            var statements = method.Body.Statements;

            if (method.ReturnType.ToString() != "void") statements = statements.Insert(0, SyntaxFactory.ParseStatement(method.ReturnType.ToString()+" rrcg_return_data = null;"));
            statements = statements.Insert(0, SyntaxFactory.ParseStatement("ExecFlow rrcg_return_flow = new ExecFlow();"));

            statements = statements.Add(SyntaxFactory.ParseStatement("ExecFlow.current.Merge(rrcg_return_flow);"));
            if (method.ReturnType.ToString() != "void") statements = statements.Add(SyntaxFactory.ParseStatement("return rrcg_return_data;"));

            method = method.WithBody(method.Body.WithStatements(statements));

            return method;
        }

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

        public override SyntaxNode VisitPredefinedType(PredefinedTypeSyntax node)
        {
            switch (node.Keyword.ValueText)
            {
                case "bool":
                    return SyntaxFactory.IdentifierName("BoolPort");
                case "string":
                    return SyntaxFactory.IdentifierName("StringPort");
                case "int":
                    return SyntaxFactory.IdentifierName("IntPort");
                case "float":
                    return SyntaxFactory.IdentifierName("FloatPort");
                case "StudioObject":
                    return SyntaxFactory.IdentifierName(node.Keyword.ValueText + "Port");
            }

            return base.VisitPredefinedType(node);
        }

        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
        {
            switch (node.Identifier.ValueText)
            {
                case "StudioObject":
                    return SyntaxFactory.IdentifierName(node.Identifier.ValueText + "Port");
            }

            return base.VisitIdentifierName(node);
        }

        public override SyntaxNode VisitBreakStatement(BreakStatementSyntax node)
        {
            return null;
        }

        public override SyntaxNode VisitThrowStatement(ThrowStatementSyntax node)
        {
            return SyntaxFactory.ParseStatement("execFlow.Clear();");
        }

        public override SyntaxNode VisitReturnStatement(ReturnStatementSyntax node)
        {
            var expression = (ExpressionSyntax)base.Visit(node.Expression);

            if (expression == null)
            {
                return SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.IdentifierName("Return"))
                    .WithArgumentList(
                        ArgumentList(
                            (ExpressionSyntax)SyntaxFactory.IdentifierName("rrcg_return_flow")
                        )
                    )
                );
            }

            return SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.IdentifierName("Return"))
                .WithArgumentList(
                    ArgumentList(
                        (ExpressionSyntax)SyntaxFactory.IdentifierName("rrcg_return_flow"),
                        (ExpressionSyntax)SyntaxFactory.IdentifierName("out rrcg_return_data"),
                        expression
                    )
                )
            );

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
                    ArgumentList(
                        test,
                        ExecDelegate().WithBlock(
                            SyntaxFactory.Block(trueStatement)
                        ),
                        ExecDelegate().WithBlock(
                            falseStatement != null ? SyntaxFactory.Block(falseStatement) : SyntaxFactory.Block()
                        )
                 )))
            .NormalizeWhitespace();
        }

        public override SyntaxNode VisitSwitchStatement(SwitchStatementSyntax node)
        {
            ExpressionSyntax test = (ExpressionSyntax)Visit(node.Expression);

            var defaultCase = ExecDelegate();

            var cases = new List<ExpressionSyntax>();

            foreach (var section in node.Sections)
            {
                var sectionFn = ExecDelegate().WithBlock((BlockSyntax)Visit(SyntaxFactory.Block(section.Statements)));

                foreach (var label in section.Labels)
                {
                    if (label.Keyword.Text == "default")
                    {
                        defaultCase = sectionFn;
                    }
                    else
                    {
                        var caseValue = (ExpressionSyntax)Visit(((CaseSwitchLabelSyntax)label).Value);

                        cases.Add(SyntaxFactory.InitializerExpression(
                            SyntaxKind.ComplexElementInitializerExpression,
                            ExpressionList(caseValue, sectionFn)));
                    }
                }
            }

            return SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.IdentifierName("ChipBuilder"),
                            SyntaxFactory.IdentifierName("ExecutionAnySwitch")))
                    .WithArgumentList(
                        ArgumentList(
                            test,
                            defaultCase,
                            SyntaxFactory.ObjectCreationExpression(
                                SyntaxFactory.GenericName(
                                    SyntaxFactory.Identifier("Dictionary"))
                                .WithTypeArgumentList(
                                    SyntaxFactory.TypeArgumentList(
                                        SyntaxFactory.SeparatedList<TypeSyntax>(
                                            new SyntaxNodeOrToken[]{
                                                SyntaxFactory.IdentifierName("AnyPort"),
                                                SyntaxFactory.Token(SyntaxKind.CommaToken),
                                                SyntaxFactory.IdentifierName("AlternativeExec")}))))
                                .WithInitializer(
                                    SyntaxFactory.InitializerExpression(
                                        SyntaxKind.CollectionInitializerExpression,
                                        ExpressionList(cases.ToArray())
                            )))
                        ))
                .NormalizeWhitespace();
        }

        public override SyntaxNode VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            string chip = null;

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
                    chip = "LessorEqual";
                    break;
                case SyntaxKind.LessThanOrEqualExpression:
                    chip = "GreaterorEqual";
                    break;
                case SyntaxKind.EqualsExpression:
                    chip = "Equals";
                    break;
            }

            if (chip != null)
            {
                ExpressionSyntax leftExpression = (ExpressionSyntax)Visit(node.Left);
                ExpressionSyntax rightExpression = (ExpressionSyntax)Visit(node.Right);

                return SyntaxFactory.InvocationExpression(
                            SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.IdentifierName("ChipBuilder"),
                                SyntaxFactory.IdentifierName(chip)))
                        .WithArgumentList(
                            ArgumentList(
                                leftExpression,
                                rightExpression
                            ))
                        .NormalizeWhitespace();
            }

            return base.VisitBinaryExpression(node);
        }


        // Helpers 
        public AnonymousMethodExpressionSyntax ExecDelegate()
        {
            return SyntaxFactory.AnonymousMethodExpression();
        }

        public ArgumentListSyntax ArgumentList(params ExpressionSyntax[] arguments)
        {
            var withCommas = CommaSeparated(arguments.Select(arg => (SyntaxNodeOrToken)SyntaxFactory.Argument(arg)));

            return SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList<ArgumentSyntax>(withCommas));
        }

        public static SeparatedSyntaxList<ExpressionSyntax> ExpressionList(params ExpressionSyntax[] arguments)
        {
            var withCommas = CommaSeparated(arguments.Select(arg => (SyntaxNodeOrToken)arg));

            return SyntaxFactory.SeparatedList<ExpressionSyntax>(withCommas);
        }

        public static SyntaxNodeOrToken[] CommaSeparated(IEnumerable<SyntaxNodeOrToken> list)
        {
            return Intersperse(list, SyntaxFactory.Token(SyntaxKind.CommaToken)).ToArray();
        }

        public static IEnumerable<T> Intersperse<T>(IEnumerable<T> source, T element)
        {
            bool first = true;
            foreach (T value in source)
            {
                if (!first) yield return element;
                yield return value;
                first = false;
            }
        }

    }
}

