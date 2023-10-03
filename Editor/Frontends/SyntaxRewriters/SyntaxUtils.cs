using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RRCG
{
    internal static class SyntaxUtils
    {
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

        public static SeparatedSyntaxList<ExpressionSyntax> ExpressionList(params ExpressionSyntax[] arguments)
        {
            var withCommas = CommaSeparated(arguments.Select(arg => (SyntaxNodeOrToken)arg));

            return SyntaxFactory.SeparatedList<ExpressionSyntax>(withCommas);
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
    }
}
