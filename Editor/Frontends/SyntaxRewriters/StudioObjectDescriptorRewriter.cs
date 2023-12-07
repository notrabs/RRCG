using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace RRCG
{
    public class StudioObjectDescriptorRewriter : CSharpSyntaxRewriter
    {
        private RRCGSyntaxRewriter rrcgRewriter;
        private BodyRewriter bodyRewriter;

        public StudioObjectDescriptorRewriter(RRCGSyntaxRewriter rrcgRewriter)
        {
            this.rrcgRewriter = rrcgRewriter;
            this.bodyRewriter = new BodyRewriter();
        }

        //
        // Class translation
        //

        public SyntaxNode VisitClassDeclarationRoot(ClassDeclarationSyntax node)
        {
            var translatedNode = (ClassDeclarationSyntax)base.VisitClassDeclaration(node);

            IEnumerable<StatementSyntax> statements = new List<StatementSyntax>()
            {
                ParseStatement("__GetImplementation().__ClearEvents(this);")
            };

            statements = statements.Concat(node.Members.Select(m =>
            {
                if (m is MethodDeclarationSyntax method)
                {

                    if (SyntaxUtils.HasAttribute(method, "StudioEvent"))
                    {
                        return ExpressionStatement(InvocationExpression(IdentifierName("__AddStudioEvent")).WithArgumentList(SyntaxUtils.ArgumentList(
                            SyntaxUtils.StringLiteral(method.Identifier.Text),
                            ParseExpression("RRCG.StudioEventType." + GetStudioEventType(method).ToString()),
                            ParenthesizedLambdaExpression().WithParameterList(method.ParameterList).WithBody(
                                (BlockSyntax)bodyRewriter.Visit(method.Body)
                            )
                        )));
                    }
                    else if (SyntaxUtils.HasAttribute(method, "StudioEventRange"))
                    {
                        return ExpressionStatement(InvocationExpression(IdentifierName("__AddStudioEventRange")).WithArgumentList(SyntaxUtils.ArgumentList(
                                new ExpressionSyntax[]
                                {
                                    SyntaxUtils.StringLiteral(method.Identifier.Text),
                                    ParseExpression("RRCG.StudioEventType." + GetStudioEventType(method).ToString()),
                                    ParenthesizedLambdaExpression().WithParameterList(method.ParameterList).WithBody(
                                        (BlockSyntax)bodyRewriter.Visit(method.Body)
                                    )
                                }.Concat(
                                    SyntaxUtils.GetAttribute(method, "StudioEventRange").ArgumentList.Arguments.Select(arg => arg.Expression)
                                ).ToArray()
                        )));
                    }
                    else if (SyntaxUtils.HasAttribute(method, "StudioFunction"))
                    {
                        // TODO: Define Syntax and update Studio Events (and leave ExistingStudioFunction intact)
                        return null;
                    }
                }

                return null;
            }).Where(m => m != null));

            statements = statements.Append(ParseStatement("__GetImplementation().__FinalizeEvents(this);"));

            return translatedNode.WithMembers(translatedNode.Members.Add(
                ((MethodDeclarationSyntax)ParseMemberDeclaration("public override void __UpdateStudioEvents() { }")).WithBody(
                    Block(statements)
                )
            ));
        }

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            return rrcgRewriter.VisitClassDeclaration(node);
        }
        public override SyntaxNode VisitSimpleBaseType(SimpleBaseTypeSyntax node)
        {
            if (node.Type.ToString() == "StudioObjectDescriptor") node = node.WithType(ParseTypeName("StudioObjectBuilder"));
            return base.VisitSimpleBaseType(node);
        }

        public override SyntaxNode VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            if (node.ParameterList.Parameters.Count != 1) throw new Exception("Expected a constructor in form of Construcor(StudioObject target)");

            return node.WithParameterList(SyntaxUtils.ParameterList(node.ParameterList.Parameters[0].WithType(IdentifierName("StudioObjectPort"))));
        }

        public override SyntaxNode VisitUnsafeStatement(UnsafeStatementSyntax node)
        {
            return node.Block;
        }

        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax method)
        {
            if (method.Modifiers.Where(t => t.Kind() == SyntaxKind.UnsafeKeyword).Count() > 0)
                return method.WithModifiers(new SyntaxTokenList(method.Modifiers.Where(t => t.Kind() != SyntaxKind.UnsafeKeyword)));

            if (IsStudioFunctionMethod(method)) return VisitStudioFunctionMethod(method);
            if (IsEventMethod(method)) return VisitStudioEventMethod(method);

            return method;
        }

        public SyntaxNode VisitStudioFunctionMethod(MethodDeclarationSyntax method)
        {
            var parameters = new List<ParameterSyntax>();
            var statements = new List<StatementSyntax>();
            var arguments = new List<ExpressionSyntax>();

            var isVoid = method.ReturnType.ToString() == "void";

            foreach (var parameter in method.ParameterList.Parameters)
            {
                string portType = GetStudioFunctionPortType(parameter.Type.ToString());
                parameters.Add(parameter.WithType(IdentifierName(portType)));
                arguments.Add(IdentifierName(parameter.Identifier));
            }

            var argumentsString = arguments.Count > 0 ? ", " + string.Join(",", arguments.Select(arg => arg.ToString())) : "";

            statements.Add(ParseStatement($"__SpawnStudioFunctionChip(\"{method.Identifier.Text}\"{argumentsString});"));

            if (!isVoid)
            {
                statements.Add(ParseStatement($"var node = Context.lastSpawnedNode;"));
                statements.Add(ReturnStatement(GetStudioFunctionReturnExpression(method)));
            }

            return method
                .WithBody(Block(statements))
                .WithParameterList(SyntaxUtils.ParameterList(parameters.ToArray()))
                .WithReturnType(GetStudioFunctionReturnType(method));
        }

        private TypeSyntax GetStudioFunctionReturnType(MethodDeclarationSyntax method)
        {
            if (method.ReturnType.ToString() == "void") return method.ReturnType;

            if (method.ReturnType is TupleTypeSyntax tuple)
            {
                return SyntaxUtils.TupleType(
                    tuple.Elements.Select((element, index) => element.WithType(ParseTypeName(GetStudioFunctionPortType(element.Type.ToString())))).ToArray()
                );
            }

            return IdentifierName(GetStudioFunctionPortType(method.ReturnType.ToString()));
        }

        private ExpressionSyntax GetStudioFunctionReturnExpression(MethodDeclarationSyntax method)
        {
            if (method.ReturnType is TupleTypeSyntax tuple)
            {
                return SyntaxUtils.TupleExpression(
                    tuple.Elements.Select((element, index) => ParseExpression($"new {GetStudioFunctionPortType(element.Type.ToString())}() {{ Port = node.Port(0,{1 + index}) }}")).ToArray()
                );
            }

            return ParseExpression($"new {GetStudioFunctionPortType(method.ReturnType.ToString())}() {{ Port = node.Port(0,1) }}");
        }

        private string GetStudioFunctionPortType(string type)
        {
            switch (type)
            {
                case "bool":
                    return "BoolPort";
                case "float":
                    return "FloatPort";
                case "int":
                    return "IntPort";
                case "string":
                    return "StringPort";
                case "Color":
                case "Color32":
                    return "ColorPort";
                case "Vector2":
                case "Vector3":
                    return "Vector3Port";
                case "Quaternion":
                    return "QuaternionPort";
                default:
                    throw new Exception("Unsupported type in Studio Function: " + type);
            }
        }

        public SyntaxNode VisitStudioEventMethod(MethodDeclarationSyntax method)
        {
            var parameters = new List<ParameterSyntax>();
            var statements = new List<StatementSyntax>();

            string eventParam = "\"" + method.Identifier.Text + "\"";

            if (SyntaxUtils.HasAttribute(method, "StudioEventRange"))
            {
                parameters.Add(method.ParameterList.Parameters[0].WithType(IdentifierName("IntPort")));

                statements.Add(ParseStatement($"var __eventName = ChipBuilder.Concat(\"{method.Identifier.Text}\", ChipBuilder.ToString({method.ParameterList.Parameters[0].Identifier}));"));
                eventParam = "__eventName";
            }

            switch (GetStudioEventType(method))
            {
                case StudioEventType.VOID:
                    statements.Add(ParseStatement($"ChipBuilder.StudioEventSender(__Target, {eventParam});"));
                    break;
                case StudioEventType.INT:
                    parameters.Add(Parameter(Identifier("param0")).WithType(IdentifierName("IntPort")));
                    statements.Add(ParseStatement($"ChipBuilder.StudioEventSenderInt(__Target, {eventParam}, param0);"));
                    break;
                case StudioEventType.BOOL:
                    parameters.Add(Parameter(Identifier("param0")).WithType(IdentifierName("BoolPort")));
                    statements.Add(ParseStatement($"ChipBuilder.StudioEventSenderBool(__Target, {eventParam}, param0);"));
                    break;
                case StudioEventType.FLOAT:
                    parameters.Add(Parameter(Identifier("param0")).WithType(IdentifierName("FloatPort")));
                    statements.Add(ParseStatement($"ChipBuilder.StudioEventSenderFloat(__Target, {eventParam}, param0);"));
                    break;
                case StudioEventType.STRING:
                    parameters.Add(Parameter(Identifier("param0")).WithType(IdentifierName("StringPort")));
                    statements.Add(ParseStatement($"ChipBuilder.StudioEventSenderString(__Target, {eventParam}, param0);"));
                    break;
                case StudioEventType.STRING_INT:
                    parameters.Add(Parameter(Identifier("param0")).WithType(IdentifierName("StringPort")));
                    parameters.Add(Parameter(Identifier("param1")).WithType(IdentifierName("IntPort")));
                    statements.Add(ParseStatement($"ChipBuilder.StudioEventSenderStringInt(__Target, {eventParam}, param0, param1);"));
                    break;
                case StudioEventType.STRING_BOOL:
                    parameters.Add(Parameter(Identifier("param0")).WithType(IdentifierName("StringPort")));
                    parameters.Add(Parameter(Identifier("param1")).WithType(IdentifierName("BoolPort")));
                    statements.Add(ParseStatement($"ChipBuilder.StudioEventSenderStringBool(__Target, {eventParam}, param0, param1);"));
                    break;
                case StudioEventType.STRING_FLOAT:
                    parameters.Add(Parameter(Identifier("param0")).WithType(IdentifierName("StringPort")));
                    parameters.Add(Parameter(Identifier("param1")).WithType(IdentifierName("FloatPort")));
                    statements.Add(ParseStatement($"ChipBuilder.StudioEventSenderStringFloat(__Target, {eventParam}, param0, param1);"));
                    break;
                case StudioEventType.STRING_STRING:
                    parameters.Add(Parameter(Identifier("param0")).WithType(IdentifierName("StringPort")));
                    parameters.Add(Parameter(Identifier("param1")).WithType(IdentifierName("StringPort")));
                    statements.Add(ParseStatement($"ChipBuilder.StudioEventSenderStringString(__Target, {eventParam}, param0, param1);"));
                    break;
                default:
                    throw new Exception("unknown StudioEventType");
            }

            return method
                .WithBody(Block(statements))
                .WithParameterList(SyntaxUtils.ParameterList(parameters.ToArray()));
        }

        /// 
        /// Utils
        /// 

        public bool IsStudioFunctionMethod(MethodDeclarationSyntax method)
        {
            return SyntaxUtils.HasAttribute(method, "StudioFunction") || SyntaxUtils.HasAttribute(method, "ExistingStudioFunction");
        }

        public bool IsEventMethod(MethodDeclarationSyntax method)
        {
            return SyntaxUtils.HasAttribute(method, "StudioEvent") || SyntaxUtils.HasAttribute(method, "StudioEventRange");
        }

        public StudioEventType GetStudioEventType(MethodDeclarationSyntax method)
        {
            var parameters = method.ParameterList.Parameters;
            if (SyntaxUtils.HasAttribute(method, "StudioEventRange")) parameters = parameters.RemoveAt(0);

            switch (parameters.Count)
            {
                case 0:
                    return StudioEventType.VOID;
                case 1:
                    switch (parameters[0].Type.ToString())
                    {
                        case "int":
                            return StudioEventType.INT;
                        case "bool":
                            return StudioEventType.BOOL;
                        case "float":
                            return StudioEventType.FLOAT;
                        case "string":
                            return StudioEventType.STRING;
                    }
                    break;
                case 2:
                    if (parameters[0].Type.ToString() != "string") throw new Exception("Method " + method.ToString() + " cannot be expressed as a UnityEvent. First parameter must be string.");

                    switch (parameters[1].Type.ToString())
                    {
                        case "int":
                            return StudioEventType.STRING_INT;
                        case "bool":
                            return StudioEventType.STRING_BOOL;
                        case "float":
                            return StudioEventType.STRING_FLOAT;
                        case "string":
                            return StudioEventType.STRING_STRING;
                    }
                    break;
            }

            throw new Exception("Method " + method.ToString() + " cannot be expressed as a UnityEvent");
        }

    }

    class BodyRewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitInvocationExpression(InvocationExpressionSyntax invocationExpression)
        {
            var invocationName = invocationExpression.Expression.ToString();

            if (
                invocationName.StartsWith("AddListener") ||
                invocationName.StartsWith("AddDynamicListener")
            )
            {
                var firstArg = invocationExpression.ArgumentList.Arguments[0].Expression;
                var otherArgs = invocationExpression.ArgumentList.Arguments.Skip(1).Select(arg => arg.Expression);

                if (firstArg is MemberAccessExpressionSyntax mae)
                {
                    return invocationExpression
                    .WithArgumentList(SyntaxUtils.ArgumentList(
                        new ExpressionSyntax[]
                        {
                            mae.Expression,
                            LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(mae.Name.ToString())),
                        }.Concat(otherArgs).ToArray()
                    ));
                }
                else throw new Exception("first argument of AddListener() must be a member access expression (e.g. gameObject.name including the dot!)");
            }

            return base.VisitInvocationExpression(invocationExpression);
        }
    }
}