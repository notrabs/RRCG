using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RRCGSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace RRCG
{
    public class StudioObjectDescriptorRewriter : CSharpSyntaxRewriter
    {
        private RRCGSyntaxRewriter rrcgRewriter;

        public StudioObjectDescriptorRewriter(RRCGSyntaxRewriter rrcgRewriter)
        {
            this.rrcgRewriter = rrcgRewriter;
        }

        //
        // Class translation
        //

        public SyntaxNode VisitClassDeclarationRoot(ClassDeclarationSyntax node)
        {
            var translatedNode = (ClassDeclarationSyntax)base.VisitClassDeclaration(node);

            IEnumerable<StatementSyntax> statements = new List<StatementSyntax>();

            statements = node.Members.Select(m =>
            {
                if (m is MethodDeclarationSyntax method)
                {

                    if (SyntaxUtils.HasAttribute(method, "StudioEvent"))
                    {
                        return ExpressionStatement(InvocationExpression(IdentifierName("__AddStudioEvent")).WithArgumentList(SyntaxUtils.ArgumentList(
                            SyntaxUtils.StringLiteral(method.Identifier.Text),
                            ParseExpression("RRCG.StudioEventType." + GetStudioEventType(method).ToString()),
                            ParenthesizedLambdaExpression().WithParameterList(method.ParameterList).WithBody(method.Body)
                        )));
                    }
                }

                return null;
            }).Where(m => m != null);

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

        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax method)
        {
            if (!IsEventMethod(method)) return method;

            var parameters = new List<ParameterSyntax>();
            var statements = new List<StatementSyntax>();

            string eventParam = "\"" + method.Identifier.Text + "\"";

            if (SyntaxUtils.HasAttribute(method, "StudioEventRange"))
            {
                parameters.Add(method.ParameterList.Parameters[0].WithType(IdentifierName("IntPort")));

                statements.Add(ParseStatement($"var __eventName = ChipBuilder.Concat(\"{method.Identifier.Text}_\", ChipBuilder.ToString({method.ParameterList.Parameters[0].Identifier}));"));
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
}