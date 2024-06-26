using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using System;
using System.Collections.Generic;

namespace RRCG
{
    public class RRCGSyntaxRewriter : CSharpSyntaxRewriter
    {
        public SemanticModel SemanticModel;

        private CircuitDescriptorRewriter circuitDescriptorRewriter;
        private StudioObjectDescriptorRewriter studioObjectDescriptorRewriter;

        public RRCGSyntaxRewriter(SemanticModel semanticModel)
        {
            SemanticModel = semanticModel;
            circuitDescriptorRewriter = new CircuitDescriptorRewriter(this);
            studioObjectDescriptorRewriter = new StudioObjectDescriptorRewriter(this);
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
            // TODO: This new approach is still not really ideal,
            //       at least for the circuit descriptors. Because inheriting
            //       all the chips means they're accessible all the way down,
            //       polluting the intellisense for CircuitLibraries.
            //
            //       Ideally we can move away from inheritance and use Attributes,
            //       and expose the chips in a static class so you can do "using static".

            var studioObjectTypes = new ITypeSymbol[]
            {
                SemanticModel.Compilation.GetTypeByMetadataName("RRCGSource.StudioObjectDescriptor")
            };

            var circuitDescriptorTypes = new ITypeSymbol[]
            {
                SemanticModel.Compilation.GetTypeByMetadataName("RRCGSource.CircuitDescriptor"),
                SemanticModel.Compilation.GetTypeByMetadataName("RRCGSource.CircuitLibrary")
            };

            var type = SemanticModel.GetDeclaredSymbol(node);
            var baseTypes = WalkInheritanceChain(type);
            
            if (baseTypes.Intersect(studioObjectTypes).Count() > 0)
                return studioObjectDescriptorRewriter.VisitClassDeclarationRoot(node);

            if (baseTypes.Intersect(circuitDescriptorTypes).Count() > 0)
                return circuitDescriptorRewriter.VisitClassDeclarationRoot(node);

            return base.VisitClassDeclaration(node);
        }

        public List<ITypeSymbol> WalkInheritanceChain(ITypeSymbol target)
        {
            var list = new List<ITypeSymbol>();
            var current = target;
            while (current.BaseType != null)
            {
                list.Add(current.BaseType);
                current = current.BaseType;
            }

            return list;
        }
    }
}

