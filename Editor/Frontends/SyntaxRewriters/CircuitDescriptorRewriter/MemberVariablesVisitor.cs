#nullable enable
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using System;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Immutable;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace RRCG
{
    internal class MemberVariablesVisitor
    {
        CircuitDescriptorRewriter CircuitDescriptorRewriter;
        SemanticModel SemanticModel;
        BuildRealmResolver BuildRealmResolver;

        public MemberVariablesVisitor(CircuitDescriptorRewriter circuitRewriter, SemanticModel semanticModel, BuildRealmResolver buildResolver)
            => (CircuitDescriptorRewriter, SemanticModel, BuildRealmResolver) = (circuitRewriter, semanticModel, buildResolver);

        /// <summary>
        /// Given a FieldDeclarationSyntax which may use a Variable attribute,
        /// validate the argument usage & return a set of new members.
        /// If the field did not use a Variable attribute, this method returns null.
        /// </summary>
        public List<MemberDeclarationSyntax>? VisitPotentialMemberVariable(FieldDeclarationSyntax field)
        {
            // Expect field to have at least one variable
            if (field.Declaration.Variables.FirstOrDefault() is not VariableDeclaratorSyntax firstVar)
                return null;

            // Ensure field has a Variable attribute
            if (SemanticModel.GetDeclaredSymbol(firstVar) is not IFieldSymbol fieldSymbol)
            {
                Debug.LogWarning($"Unable to determine symbol for FieldDeclarationSyntax: {field}");
                return null;
            }

            var attributes = fieldSymbol.GetAttributes();
            var attributeInfo = GetVariableAttribute(attributes);
            if (!attributeInfo.HasValue) return null;

            var attribute = attributeInfo.Value.Attribute;
            var attributeClass = attributeInfo.Value.Class;

            // Cloud variables have special behaviour we need to enforce.
            var attributeArgs = attribute.ConstructorArguments;
            var isCloudVariable = attributeClass == BuildRealmResolver.CloudVariableAttribute;
            if (isCloudVariable)
            {
                // The number of declared variables must match the number of arguments
                if (attributeArgs.Length <= 0 || attributeArgs[0].Kind != TypedConstantKind.Array ||
                    field.Declaration.Variables.Count != attributeArgs[0].Values.Length)
                    throw new Exception("You must supply a cloud variable name for each member in the field declaration!");

                // The arguments must all be strings, and they must be unique.
                var uniqueStrings = attributeArgs[0].Values.Where(a => a.Type?.SpecialType == SpecialType.System_String)
                                                           .Select(a => (string)a.Value!).Distinct();

                if (uniqueStrings.Count() != attributeArgs[0].Values.Length)
                    throw new Exception("[CloudVariable] attribute arguments must consist of unique string literals!");
            }

            // Now we can begin creating variable fields & properties.
            var buildType = BuildRealmResolver.ResolveOrRewriteBuildRealmType(fieldSymbol.Type);
            var newMembers = new List<MemberDeclarationSyntax>();
            for (int i = 0; i < field.Declaration.Variables.Count; i++)
            {
                var variable = field.Declaration.Variables[i];
                var variableName = variable.Identifier.ToString();
                var rrVariableName = isCloudVariable ? (string)attributeArgs[0].Values[i].Value! : variableName;

                newMembers.AddRange(CreateMemberVariable(attributeClass, buildType, field.Modifiers, variableName, rrVariableName,
                                                         variable.Initializer?.Value, TokenList(), TokenList()));
            }

            return newMembers;
        }

        /// <summary>
        /// Given a PropertyDeclarationSyntax which may use a Variable attribute,
        /// validate the argument usage & return a set of new members.
        /// If the property did not use a Variable attribute, this method returns null.
        /// </summary>
        public List<MemberDeclarationSyntax>? VisitPotentialMemberVariable(PropertyDeclarationSyntax property)
        {
            // Ensure property has a Variable attribute
            if (SemanticModel.GetDeclaredSymbol(property) is not IPropertySymbol propertySymbol)
            {
                Debug.LogWarning($"Unable to determine symbol for PropertyDeclarationSyntax: {property}");
                return null;
            }

            var attributes = propertySymbol.GetAttributes();
            var attributeInfo = GetVariableAttribute(attributes);
            if (!attributeInfo.HasValue) return null;

            var attribute = attributeInfo.Value.Attribute;
            var attributeClass = attributeInfo.Value.Class;

            // Ensure the property is auto-implemented..
            if (!property.IsAutoImplemented())
                throw new Exception($"Property must be auto-implemented to use [{attributeClass.Name}] attribute!");

            // Ensure the property has a getter and setter..
            (var getter, var setter) = property.GetAccessors();
            if (getter == null || setter == null)
                throw new Exception($"Property must define a getter and setter to use [{attributeClass.Name}] attribute!");

            // Cloud variables have special behaviour we need to enforce.
            var attributeArgs = attribute.ConstructorArguments;
            var isCloudVariable = attributeClass == BuildRealmResolver.CloudVariableAttribute;
            if (isCloudVariable)
            {
                // You can only define one "variable" per property, so there must be only one argument.
                if (attributeArgs.Length <= 0 || attributeArgs[0].Kind != TypedConstantKind.Array || attributeArgs[0].Values.Length != 1)
                    throw new Exception("You must supply exactly one cloud variable name for the property declaration!");

                // The argument must be a string literal.
                if (attributeArgs[0].Values[0].Type?.SpecialType != SpecialType.System_String)
                    throw new Exception("[CloudVariable] attribute arguments must consist of unique string literals!");
            }

            // Resolve/rewrite build type, and return the new members.
            var buildType = BuildRealmResolver.ResolveOrRewriteBuildRealmType(propertySymbol.Type);
            var variableName = property.Identifier.ToString();
            var rrVariableName = isCloudVariable ? (string)attributeArgs[0].Values[0].Value! : variableName;

            return CreateMemberVariable(attributeClass, buildType, property.Modifiers, variableName, rrVariableName,
                                        property.Initializer?.Value, getter.Modifiers, setter.Modifiers);
        }

        List<MemberDeclarationSyntax> CreateMemberVariable(INamedTypeSymbol attributeType, TypeSyntax buildType, SyntaxTokenList modifiers, string sourceName, string rrVariableName,
                                                           ExpressionSyntax? homeValue, SyntaxTokenList getModifiers, SyntaxTokenList setModifiers)
        {
            var newMembers = new List<MemberDeclarationSyntax>();

            // Create underlying NamedVariable field, to store the Variable
            var varFieldModifiers = new SyntaxTokenList(modifiers.Where(m => m.Kind() != SyntaxKind.PublicKeyword));
            if (!varFieldModifiers.Any(SyntaxKind.PrivateKeyword))
                varFieldModifiers = varFieldModifiers.Add(Token(SyntaxKind.PrivateKeyword));

            var fieldName = $"__RRCG_MEMBER_VARIABLE_{sourceName}";
            var homeValueExpression = homeValue != null ? (ExpressionSyntax)CircuitDescriptorRewriter.Visit(homeValue)
                                                        : PostfixUnaryExpression(SyntaxKind.SuppressNullableWarningExpression,
                                                                                 LiteralExpression(SyntaxKind.NullLiteralExpression));

            newMembers.Add(FieldDeclaration(
                               VariableDeclaration(
                                   GenericName("NamedVariable")
                                  .WithTypeArgumentList(
                                      SyntaxUtils.TypeArgumentList(buildType)))
                               .WithVariables(
                                   SingletonSeparatedList(
                                       VariableDeclarator(fieldName)
                                       .WithInitializer(
                                           EqualsValueClause(
                                               InvocationExpression(
                                                   GenericName("__CreateNamedVariable")
                                                   .WithTypeArgumentList(
                                                       SyntaxUtils.TypeArgumentList(buildType)))
                                               .WithArgumentList(
                                                   SyntaxUtils.ArgumentList(
                                                       SyntaxUtils.StringLiteral(rrVariableName),
                                                       homeValueExpression,
                                                       VariableKindAccessor(attributeType))))))))
                           .WithModifiers(varFieldModifiers));

            // Now create a property to access it with the original syntax
            var valueAccessor = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                                                        IdentifierName(fieldName), IdentifierName("Value"));

            newMembers.Add(PropertyDeclaration(buildType, sourceName)
                           .WithAccessorList(
                                SyntaxUtils.AccessorList(
                                    // Get accessor
                                    AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithModifiers(getModifiers)
                                    .WithExpressionBody(
                                        ArrowExpressionClause(valueAccessor))
                                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),

                                    // Set accessor
                                    AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                    .WithModifiers(setModifiers)
                                    .WithExpressionBody(
                                        ArrowExpressionClause(
                                            AssignmentExpression(
                                                SyntaxKind.SimpleAssignmentExpression,
                                                valueAccessor,
                                                IdentifierName("value"))))
                                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))))
                           .WithModifiers(modifiers));

            return newMembers;
        }

        (AttributeData Attribute, INamedTypeSymbol Class)? GetVariableAttribute(ImmutableArray<AttributeData> attributes)
        {
            var attribute = attributes.FirstOrDefault(a => a.AttributeClass == BuildRealmResolver.VariableAttribute ||
                                                           a.AttributeClass == BuildRealmResolver.SyncedVariableAttribute ||
                                                           a.AttributeClass == BuildRealmResolver.CloudVariableAttribute);
            if (attribute == null)
                return null;

            return (attribute, attribute.AttributeClass!);
        }

        MemberAccessExpressionSyntax VariableKindAccessor(INamedTypeSymbol attributeClass)
        {
            string variableKind = attributeClass == BuildRealmResolver.VariableAttribute ? "Local" :
                                  attributeClass == BuildRealmResolver.SyncedVariableAttribute ? "Synced" :
                                  attributeClass == BuildRealmResolver.CloudVariableAttribute ? "Cloud" :
                                  throw new Exception($"Unknown variable attribute {attributeClass.Name}!");

            return MemberAccessExpression(
                       SyntaxKind.SimpleMemberAccessExpression,
                       IdentifierName("VariableKind"),
                       IdentifierName(variableKind));
        }
    }
}
#nullable disable