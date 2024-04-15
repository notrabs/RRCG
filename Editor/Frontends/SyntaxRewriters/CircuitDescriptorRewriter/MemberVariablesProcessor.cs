using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using System;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace RRCG
{
    public partial class CircuitDescriptorRewriter : CSharpSyntaxRewriter
    {
        private class MemberVariablesProcessor
        {
            private CircuitDescriptorRewriter CircuitDescriptorRewriter;

            public MemberVariablesProcessor(CircuitDescriptorRewriter circuitRewriter)
            {
                CircuitDescriptorRewriter = circuitRewriter;
            }

            public List<MemberDeclarationSyntax> ProcessMemberVariables(List<MemberDeclarationSyntax> allMembers)
            {
                var newMembers = new List<MemberDeclarationSyntax>();

                foreach (var member in allMembers.ToList()) // shallow copy
                {
                    // Skip over unsafe members
                    if (member.Modifiers.Any(SyntaxKind.UnsafeKeyword)) continue;

                    // Ensure member has a Variable attribute
                    var variableAttr = member.AttributeLists.SelectMany(c => c.Attributes)
                                           .FirstOrDefault(a => a.Name.ToString() == "Variable" ||
                                                       a.Name.ToString() == "SyncedVariable" ||
                                                       a.Name.ToString() == "CloudVariable");
                    if (variableAttr == null) continue;

                    var attributeName = variableAttr.Name.ToString();
                    var attributeArgs = variableAttr.ArgumentList?.Arguments ?? new();

                    // Break out into type-specific logic
                    if (member is FieldDeclarationSyntax field)
                        VisitPotentialMemberVariable(field, allMembers, newMembers, attributeName, attributeArgs);
                    else if (member is PropertyDeclarationSyntax property)
                        VisitPotentialMemberVariable(property, allMembers, newMembers, attributeName, attributeArgs);
                    else
                        throw new Exception($"Attribute [{attributeName}] is not supported for member of kind {member.Kind()}!");
                }

                return newMembers;
            }

            void VisitPotentialMemberVariable(FieldDeclarationSyntax field,
                          List<MemberDeclarationSyntax> allMembers,
                          List<MemberDeclarationSyntax> newMembers,
                          string attribute,
                          SeparatedSyntaxList<AttributeArgumentSyntax> attributeArgs)
            {
                // Cloud variables have special behaviour we need to enforce.
                if (attribute == "CloudVariable")
                {
                    // The number of declared variables must match the number of arguments
                    if (field.Declaration.Variables.Count != attributeArgs.Count)
                        throw new Exception("You must supply a cloud variable name for each member in the field declaration!");

                    // The arguments must all be strings, and they must be unique.
                    var uniqueStrings = attributeArgs.Where(a => a.Expression.Kind() == SyntaxKind.StringLiteralExpression)
                                            .Select(a => a.Expression.ToString()).Distinct();

                    if (uniqueStrings.Count() != attributeArgs.Count)
                        throw new Exception("[CloudVariable] attribute arguments must consist of unique string literals!");
                }

                // Setup NamedVariable type
                // Need to re-parse so the root is TypeSyntax, see CircuitDescriptorRewriter.VisitIdentifierName
                var rewrittenType = (TypeSyntax)CircuitDescriptorRewriter.Visit(ParseTypeName(field.Declaration.Type.ToString()));
                var namedVariableType = GenericName("NamedVariable")
                                            .WithTypeArgumentList(
                                                SyntaxUtils.TypeArgumentList(rewrittenType));

                // Setup modifiers for the underlying NamedVariable field
                var varFieldModifiers = new SyntaxTokenList(field.Modifiers.Where(m => m.Kind() != SyntaxKind.PublicKeyword));
                if (!varFieldModifiers.Any(SyntaxKind.PrivateKeyword))
                    varFieldModifiers = varFieldModifiers.Add(Token(SyntaxKind.PrivateKeyword));

                // Now we can begin creating variable fields & properties.
                for (int i = 0; i < field.Declaration.Variables.Count; i++)
                {
                    var variable = field.Declaration.Variables[i];

                    var variableName = variable.Identifier.ToString();
                    var fieldName = $"__RRCG_MEMBER_VARIABLE_{variableName}";

                    // Create a private field to store & create the variable
                    var rrVariableName = attribute == "CloudVariable"
                        ? ((LiteralExpressionSyntax)attributeArgs[i].Expression).Token.ValueText
                        : variableName;

                    var homeValueExpression = variable.Initializer?.Value ?? PostfixUnaryExpression(SyntaxKind.SuppressNullableWarningExpression,
                                                                                LiteralExpression(SyntaxKind.NullLiteralExpression));

                    newMembers.Add(FieldDeclaration(
                        VariableDeclaration(namedVariableType)
                        .WithVariables(
                            SingletonSeparatedList(
                                VariableDeclarator(fieldName)
                                .WithInitializer(
                                    EqualsValueClause(
                                        InvocationExpression(
                                            GenericName("__CreateNamedVariable")
                                            .WithTypeArgumentList(
                                                SyntaxUtils.TypeArgumentList(rewrittenType)))
                                        .WithArgumentList(
                                            SyntaxUtils.ArgumentList(
                                                SyntaxUtils.StringLiteral(rrVariableName),
                                                homeValueExpression,
                                                VariableKindAccessor(attribute)))))))).WithModifiers(varFieldModifiers));

                    // Now create a property to access it with the original syntax
                    var valueAccessor = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                                                               IdentifierName(fieldName), IdentifierName("Value"));

                    newMembers.Add(PropertyDeclaration(rewrittenType, variableName)
                        .WithAccessorList(
                            AccessorList(
                                List<AccessorDeclarationSyntax>(
                                    new AccessorDeclarationSyntax[]
                                    {
                                        AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                        .WithExpressionBody(
                                            ArrowExpressionClause(valueAccessor))
                                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                                        AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                        .WithExpressionBody(
                                            ArrowExpressionClause(
                                                AssignmentExpression(
                                                    SyntaxKind.SimpleAssignmentExpression,
                                                    valueAccessor,
                                                    IdentifierName("value"))))
                                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                    })))
                        .WithModifiers(field.Modifiers));
                }

                // Finally remove the field declaration from the existing members
                allMembers.Remove(field);
            }

            void VisitPotentialMemberVariable(PropertyDeclarationSyntax property,
                                      List<MemberDeclarationSyntax> allMembers,
                                      List<MemberDeclarationSyntax> newMembers,
                                      string attribute,
                                      SeparatedSyntaxList<AttributeArgumentSyntax> attributeArgs)
            {
                // Ensure the property is auto-implemented..
                if (!property.IsAutoImplemented())
                    throw new Exception($"Property must be auto-implemented to use [{attribute}] attribute!");

                // Ensure the property has a getter and setter..
                (var getter, var setter) = property.GetAccessors();
                if (getter == null || setter == null)
                    throw new Exception($"Property must define a getter and setter to use [{attribute}] attribute!");

                // Cloud variables have special behaviour we need to enforce.
                if (attribute == "CloudVariable")
                {
                    // You can only define one "variable" per property,
                    // so there must be only one argument.
                    if (attributeArgs.Count != 1)
                        throw new Exception("You must supply exactly one cloud variable name for the property declaration!");

                    // The argument must be a string literal.
                    if (attributeArgs[0].Expression.Kind() != SyntaxKind.StringLiteralExpression)
                        throw new Exception("[CloudVariable] attribute arguments must consist of unique string literals!");
                }

                // Setup NamedVariable type
                // Need to re-parse so the root is TypeSyntax, see CircuitDescriptorRewriter.VisitIdentifierName
                var rewrittenType = (TypeSyntax)CircuitDescriptorRewriter.Visit(ParseTypeName(property.Type.ToString()));
                var namedVariableType = GenericName("NamedVariable")
                                            .WithTypeArgumentList(
                                                SyntaxUtils.TypeArgumentList(rewrittenType));

                // Setup modifiers for the underlying NamedVariable field
                var varFieldModifiers = new SyntaxTokenList(property.Modifiers.Where(m => m.Kind() != SyntaxKind.PublicKeyword));
                if (!varFieldModifiers.Any(SyntaxKind.PrivateKeyword))
                    varFieldModifiers = varFieldModifiers.Add(Token(SyntaxKind.PrivateKeyword));

                // Now we can create the underlying variable & new property.
                var variableName = property.Identifier.ToString();
                var fieldName = $"__RRCG_MEMBER_VARIABLE_{variableName}";

                // Create a private field to store & create the variable
                var rrVariableName = attribute == "CloudVariable"
                    ? ((LiteralExpressionSyntax)attributeArgs[0].Expression).Token.ValueText
                    : variableName;

                var homeValueExpression = property.Initializer?.Value ?? PostfixUnaryExpression(SyntaxKind.SuppressNullableWarningExpression,
                                                                            LiteralExpression(SyntaxKind.NullLiteralExpression));

                newMembers.Add(FieldDeclaration(
                    VariableDeclaration(namedVariableType)
                    .WithVariables(
                        SingletonSeparatedList(
                            VariableDeclarator(fieldName)
                            .WithInitializer(
                                EqualsValueClause(
                                    InvocationExpression(
                                        GenericName("__CreateNamedVariable")
                                        .WithTypeArgumentList(
                                            SyntaxUtils.TypeArgumentList(rewrittenType)))
                                    .WithArgumentList(
                                        SyntaxUtils.ArgumentList(
                                            SyntaxUtils.StringLiteral(rrVariableName),
                                            homeValueExpression,
                                            VariableKindAccessor(attribute)))))))).WithModifiers(varFieldModifiers));

                // Now we create a new property to access it.
                // We could technically mutate the existing property into a new one,
                // but we only really want to carry over the modifiers for the property & accessors.
                var valueAccessor = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                                                            IdentifierName(fieldName), IdentifierName("Value"));

                newMembers.Add(PropertyDeclaration(rewrittenType, variableName)
                    .WithAccessorList(
                        AccessorList(
                            List<AccessorDeclarationSyntax>(
                                new AccessorDeclarationSyntax[]
                                {
                                    AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithModifiers(getter.Modifiers)
                                    .WithExpressionBody(
                                        ArrowExpressionClause(valueAccessor))
                                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                                    AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                    .WithModifiers(setter.Modifiers)
                                    .WithExpressionBody(
                                        ArrowExpressionClause(
                                            AssignmentExpression(
                                                SyntaxKind.SimpleAssignmentExpression,
                                                valueAccessor,
                                                IdentifierName("value"))))
                                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                })))
                    .WithModifiers(property.Modifiers));

                // Finally remove the field declaration from the class members.
                allMembers.Remove(property);
            }

            MemberAccessExpressionSyntax VariableKindAccessor(string attributeName)
            {
                return MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("VariableKind"),
                                        IdentifierName(attributeName switch
                                        {
                                            "Variable" => "Local",
                                            "SyncedVariable" => "Synced",
                                            "CloudVariable" => "Cloud",
                                            _ => throw new NotImplementedException($"Unknown variable attribute [{attributeName}]!")
                                        }));
            }
        }
    }
}