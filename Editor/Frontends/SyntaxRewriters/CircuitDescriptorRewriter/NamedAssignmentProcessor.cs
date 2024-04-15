using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;


namespace RRCG
{
    public partial class CircuitDescriptorRewriter : CSharpSyntaxRewriter
    {
        private class NamedAssignmentProcessor
        {
            private CircuitDescriptorRewriter CircuitDescriptorRewriter;

            public NamedAssignmentProcessor(CircuitDescriptorRewriter circuitRewriter)
            {
                CircuitDescriptorRewriter = circuitRewriter;
            }

            public List<MemberDeclarationSyntax> ProcessMemberAssignments(List<MemberDeclarationSyntax> allMembers)
            {
                var newMembers = new List<MemberDeclarationSyntax>();

                foreach (var member in allMembers.ToList()) // shallow copy
                {
                    // Skip unsafe members.
                    if (member.Modifiers.Any(SyntaxKind.UnsafeKeyword)) continue;

                    // Ensure we're dealing with a field declaration.
                    // TODO: Is there anything else we should process here?
                    if (member is not FieldDeclarationSyntax fieldDecl) continue;

                    // Resolve build-realm type for field declaration
                    // Need to re-parse so the root is TypeSyntax, see CircuitDescriptorRewriter.VisitIdentifierName
                    var rewrittenType = (TypeSyntax)CircuitDescriptorRewriter.Visit(ParseTypeName(fieldDecl.Declaration.Type.ToString()));
                    var invocationName = GenericName("__NamedAssignment")
                        .WithTypeArgumentList(SyntaxUtils.TypeArgumentList(rewrittenType));

                    // Now we can create new field initializers
                    foreach (var variable in fieldDecl.Declaration.Variables)
                    {
                        var identifier = variable.Identifier.ToString();
                        var initializer = variable.Initializer;
                        var newVariable = VariableDeclarator(Identifier(identifier));

                        // Add an initializer?
                        if (initializer != null)
                        {
                            // Create a call to __NamedExpression, which will preserve the source naming.
                            var invocation = InvocationExpression(invocationName)
                                                .WithArgumentList(
                                                    SyntaxUtils.ArgumentList(
                                                        SyntaxUtils.StringLiteral(identifier),
                                                        ParenthesizedLambdaExpression()
                                                        .WithExpressionBody(initializer.Value)));

                            newVariable = newVariable.WithInitializer(EqualsValueClause(invocation));
                        }

                        // Finally, add the new field to the members.
                        newMembers.Add(FieldDeclaration(
                            VariableDeclaration(rewrittenType)
                            .WithVariables(
                                SingletonSeparatedList<VariableDeclaratorSyntax>(
                                    newVariable))));
                    }

                    // Now that we've processed all the variables in the field,
                    // we need to remove the original declaration from the members.
                    allMembers.Remove(fieldDecl);
                }

                // Finally, return the new members we've created.
                return newMembers;
            }
        }
    }
}