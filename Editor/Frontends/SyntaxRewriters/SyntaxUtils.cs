using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using NUnit.Framework;

namespace RRCG
{
    public static class SyntaxUtils
    {
        // Used for rewriting assignments into __Assign calls,
        // helps turn add/subtract/etc assignments (+=, -=, /=) into standard binary expressions.
        public static Dictionary<SyntaxKind, SyntaxKind> AssignmentExpressionToBinaryExpression = new()
        {
            { SyntaxKind.AddAssignmentExpression, SyntaxKind.AddExpression },
            { SyntaxKind.AndAssignmentExpression, SyntaxKind.BitwiseAndExpression }, // why do we have logical/bitwise "and" kinds if the assignment uses the same for both anyway?
            { SyntaxKind.CoalesceAssignmentExpression, SyntaxKind.CoalesceExpression },
            { SyntaxKind.DivideAssignmentExpression,  SyntaxKind.DivideExpression },
            { SyntaxKind.ExclusiveOrAssignmentExpression, SyntaxKind.ExclusiveOrExpression },
            { SyntaxKind.LeftShiftAssignmentExpression, SyntaxKind.LeftShiftExpression },
            { SyntaxKind.ModuloAssignmentExpression, SyntaxKind.ModuloExpression },
            { SyntaxKind.MultiplyAssignmentExpression, SyntaxKind.MultiplyExpression },
            { SyntaxKind.OrAssignmentExpression, SyntaxKind.BitwiseOrExpression }, // Same as above, funny enough I haven't been able to get Roslyn Quoter to generate code w/ logical variants.
            { SyntaxKind.RightShiftAssignmentExpression, SyntaxKind.RightShiftExpression },
            { SyntaxKind.SubtractAssignmentExpression, SyntaxKind.SubtractExpression }
        };

        // List of AssignmentExpressionSyntax assignment kinds.
        public static SyntaxKind[] AssignmentExpressionKinds = AssignmentExpressionToBinaryExpression.Keys.Append(SyntaxKind.SimpleAssignmentExpression).ToArray();

        // List of PrefixUnaryExpressionSyntax assignment kinds
        public static SyntaxKind[] PrefixUnaryAssignmentKinds = new[] { SyntaxKind.PreIncrementExpression, SyntaxKind.PreDecrementExpression };

        // List of PostfixUnaryExpressionSyntax assignment kinds
        public static SyntaxKind[] PostfixUnaryAssignmentKinds = new[] { SyntaxKind.PostIncrementExpression, SyntaxKind.PostDecrementExpression };

        // List of all assignment kinds.
        public static SyntaxKind[] AllAssignmentKinds = AssignmentExpressionKinds
            .Concat(PrefixUnaryAssignmentKinds)
            .Concat(PostfixUnaryAssignmentKinds)
            .ToArray();

        public static ExpressionSyntax StringLiteral(string value)
        {
            return SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(value));
        }
        public static TypeSyntax TupleType(params TupleElementSyntax[] elements)
        {
            var withCommas = CommaSeparated(elements.Select(arg => (SyntaxNodeOrToken)arg));

            return SyntaxFactory.TupleType(SyntaxFactory.SeparatedList<TupleElementSyntax>(withCommas));
        }
        public static TupleExpressionSyntax TupleExpression(params ExpressionSyntax[] elements)
        {
            var withCommas = CommaSeparated(elements.Select(arg => (SyntaxNodeOrToken)SyntaxFactory.Argument(arg)));

            return SyntaxFactory.TupleExpression(SyntaxFactory.SeparatedList<ArgumentSyntax>(withCommas));
        }
        public static ArgumentListSyntax ArgumentList(params ExpressionSyntax[] arguments)
        {
            var withCommas = CommaSeparated(arguments.Select(arg => (SyntaxNodeOrToken)SyntaxFactory.Argument(arg)));

            return SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList<ArgumentSyntax>(withCommas));
        }
        public static TypeArgumentListSyntax TypeArgumentList(params TypeSyntax[] arguments)
        {
            var withCommas = CommaSeparated(arguments.Select(arg => (SyntaxNodeOrToken)arg));

            return SyntaxFactory.TypeArgumentList(SyntaxFactory.SeparatedList<TypeSyntax>(withCommas));
        }
        public static TypeParameterListSyntax TypeParameterList(params TypeParameterSyntax[] arguments)
        {
            var withCommas = CommaSeparated(arguments.Select(arg => (SyntaxNodeOrToken)arg));

            return SyntaxFactory.TypeParameterList(SyntaxFactory.SeparatedList<TypeParameterSyntax>(withCommas));
        }
        public static SyntaxList<TypeParameterConstraintClauseSyntax> TypeParameterConstraintList(params TypeParameterConstraintClauseSyntax[] arguments)
        {
            return SyntaxFactory.List(arguments);
        }
        public static TypeParameterConstraintClauseSyntax TypeParameterConstraintClause(IdentifierNameSyntax identifier, params TypeParameterConstraintSyntax[] constraints)
        {
            var withCommas = CommaSeparated(constraints.Select(arg => (SyntaxNodeOrToken)arg));

            return SyntaxFactory.TypeParameterConstraintClause(identifier)
                    .WithConstraints(SyntaxFactory.SeparatedList<TypeParameterConstraintSyntax>(withCommas));
        }

        public static SeparatedSyntaxList<ExpressionSyntax> ExpressionList(params ExpressionSyntax[] arguments)
        {
            var withCommas = CommaSeparated(arguments.Select(arg => (SyntaxNodeOrToken)arg));

            return SyntaxFactory.SeparatedList<ExpressionSyntax>(withCommas);
        }
        public static ParameterListSyntax ParameterList(params ParameterSyntax[] parameters)
        {
            var withCommas = CommaSeparated(parameters.Select(arg => (SyntaxNodeOrToken)arg));

            return SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList<ParameterSyntax>(withCommas));
        }
        public static BaseListSyntax BaseList(params BaseTypeSyntax[] baseTypes)
        {
            var withCommas = CommaSeparated(baseTypes.Select(arg => (SyntaxNodeOrToken)arg));

            return SyntaxFactory.BaseList(SyntaxFactory.SeparatedList<BaseTypeSyntax>(withCommas));
        }
        public static AccessorListSyntax AccessorList(params AccessorDeclarationSyntax[] accessors)
        {
            return SyntaxFactory.AccessorList(SyntaxFactory.List(accessors));
        }

        public static SyntaxList<UsingDirectiveSyntax> Usings(params string[] usings)
        {
            return SyntaxFactory.List(
                usings.Select(u => SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName(u))).ToArray()
            );
        }

        public static PropertyDeclarationSyntax AddAccesor(PropertyDeclarationSyntax property, AccessorDeclarationSyntax accessor)
        {
            var newAccesorArr = new[] { accessor };
            return property.WithAccessorList(AccessorList(property.AccessorList != null ? property.AccessorList.Accessors.Concat(newAccesorArr).ToArray() : newAccesorArr));
        }

        public static bool IsBlockVoid(BlockSyntax block)
        {
            return !block.Statements.Any(s => s is ReturnStatementSyntax returnStatement && returnStatement.Expression != null);
        }

        public static BlockSyntax WrapInBlock(SyntaxNode node)
        {
            if (node == null) return SyntaxFactory.Block();
            if (node is BlockSyntax) return (BlockSyntax)node;
            if (node is StatementSyntax) return SyntaxFactory.Block((StatementSyntax)node);
            Debug.LogError(node);
            throw new Exception("SyntaxNode can't be wrapped in block");
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

        public static bool HasAttribute(MethodDeclarationSyntax method, string attrName)
        {
            return GetAttribute(method, attrName) != null;
        }

        public static AttributeSyntax GetAttribute(MethodDeclarationSyntax method, string attrName)
        {
            foreach (var attrList in method.AttributeLists)
            {
                var attr = attrList.Attributes.FirstOrDefault(attr => attr.Name.ToString() == attrName);
                if (attr != null) return attr;
            }
            return null;
        }

        public static TypeSyntax ToTypeSyntax(this ITypeSymbol symbol)
        {
            var str = symbol.ToString();
            if (str == "?")
                throw new Exception("Type symbol did not resolve correctly!");

            return SyntaxFactory.ParseTypeName(str);
        }

        public static T StripTrivia<T>(this T node) where T : SyntaxNode
        {
            return node.WithoutLeadingTrivia().WithoutTrailingTrivia();
        }

        public static ITypeSymbol GetResolvedType(this ISymbol symbolInfo)
        {
            ITypeSymbol resolvedType = null;

            switch (symbolInfo.Kind)
            {
                case SymbolKind.Field:
                    resolvedType = ((IFieldSymbol)symbolInfo).Type;
                    break;
                case SymbolKind.Local:
                    resolvedType = ((ILocalSymbol)symbolInfo).Type;
                    break;
            }

            // Using null check for short-circuit
            if (resolvedType == null || resolvedType.ToString() == "?")
                return null;

            return resolvedType;
        }

        public static IEnumerable<ISymbol> GetAccessibleSymbols(this SemanticModel semanticModel, int position, params SymbolKind[] filterKinds)
        {
            var symbols = semanticModel.LookupSymbols(position);

            return semanticModel.LookupSymbols(position)
                .Where(s => filterKinds.Contains(s.Kind))
                .Where(symbol =>
                {
                    if (symbol.IsImplicitlyDeclared) return true;

                    // TODO: do we need to handle multiple declarations?
                    var declaration = symbol.DeclaringSyntaxReferences.Select(s => s.GetSyntax()).FirstOrDefault();
                    if (declaration == null) return false;

                    return position > declaration.SpanStart;
                }).ToArray();
        }

        public static (AccessorDeclarationSyntax Getter, AccessorDeclarationSyntax Setter) GetAccessors(this PropertyDeclarationSyntax property)
        {
            AccessorDeclarationSyntax getter = null;
            AccessorDeclarationSyntax setter = null;

            var accessors = property.AccessorList?.Accessors;
            if (accessors == null) return (null, null);

            foreach (var accessor in property.AccessorList!.Accessors!)
            {
                var accessorKind = accessor.Kind();
                if (accessorKind == SyntaxKind.GetAccessorDeclaration) getter = accessor;
                if (accessorKind == SyntaxKind.SetAccessorDeclaration) setter = accessor;
            }

            return (getter, setter);
        }

        public static bool IsAutoImplemented(this PropertyDeclarationSyntax property)
        {
            // string myProperty => "readonly";
            if (property.AccessorList == null) return false;

            return property.AccessorList.Accessors.All(a => a.Body == null && a.ExpressionBody == null);
        }
    }
}
