using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using System;

namespace RRCG
{
    public class RRCGSyntaxRewriter : CSharpSyntaxRewriter
    {
        private CircuitDescriptorRewriter circuitDescriptorRewriter;
        private StudioObjectDescriptorRewriter studioObjectDescriptorRewriter;
        private CSharpCompilation Compilation;

        public RRCGSyntaxRewriter(CSharpCompilation initialCompilation)
        {
            Compilation = initialCompilation;
            circuitDescriptorRewriter = new CircuitDescriptorRewriter(this);
            studioObjectDescriptorRewriter = new StudioObjectDescriptorRewriter(this);
        }

        public SemanticModel GetUpdatedSemanticModel(SyntaxTree tree)
        {
            // Update compilation with new tree if necessary
            if (!Compilation.ContainsSyntaxTree(tree))
                Compilation = Compilation.AddSyntaxTrees(tree);

            return Compilation.GetSemanticModel(tree);
        }

        //
        // Class and Module
        // 

        public override SyntaxNode VisitCompilationUnit(CompilationUnitSyntax node)
        {
            // We visit the compilation unit before altering its usings
            // so that method symbols can resolve correctly to their source-realm versions.
            var compiled = (CompilationUnitSyntax)base.VisitCompilationUnit(node);

            if (compiled.Usings.Any(u => u.Name.ToString() == "RRCGSource"))
            {
                compiled.RemoveNode(compiled.Usings.First(u => u.Name.ToString() == "RRCGSource"), SyntaxRemoveOptions.KeepNoTrivia);
            }

            if (!compiled.Usings.Any(u => u.Name.ToString() == "RRCGBuild"))
            {
                compiled = compiled.AddUsings(UsingDirective(ParseName("RRCGBuild")).WithAdditionalAnnotations(Microsoft.CodeAnalysis.Formatting.Formatter.Annotation));
            }

            if (!compiled.Usings.Any(u => u.Name.ToString() == "System.Collections.Generic"))
            {
                compiled = compiled.AddUsings(UsingDirective(ParseName("System.Collections.Generic")).WithAdditionalAnnotations(Microsoft.CodeAnalysis.Formatting.Formatter.Annotation));
            }

            return compiled.WithMembers(SingletonList<MemberDeclarationSyntax>(
                NamespaceDeclaration(IdentifierName("RRCGBuild"))
                .WithMembers(compiled.Members)
            ));
        }

        public override SyntaxNode VisitUsingDirective(UsingDirectiveSyntax node)
        {
            if (node.Name.ToString() == "RRCGSource")
            {
                return null;
            }
            return base.VisitUsingDirective(node);
        }

        public override SyntaxNode VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            throw new Exception("Namespaces are not allowed in RRCG files. They are reserved for the compiler");
        }

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (node.BaseList?.Types.Any(t =>
                t.ToString().Contains("StudioObjectDescriptor")) ?? false)
                return studioObjectDescriptorRewriter.VisitClassDeclarationRoot(node);
            if (node.BaseList?.Types.Any(t =>
                t.ToString().Contains("CircuitDescriptor") ||
                t.ToString().Contains("IntPacker") || // This is really not ideal...
                t.ToString().Contains("CircuitLibrary")) ?? false)
                return circuitDescriptorRewriter.VisitClassDeclarationRoot(node);

            return base.VisitClassDeclaration(node);
        }
    }
}

