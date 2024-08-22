#nullable enable
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace RRCG
{
    public class BuildRealmResolver
    {
        SemanticModel SemanticModel;
        Compilation Compilation => SemanticModel.Compilation;

        // Map known source-realm type symbols -> build-realm type symbols
        Dictionary<ITypeSymbol, ITypeSymbol> SourceToBuildRealmType = new();

        // Public references to known namespace symbols
        public INamespaceSymbol RRCGSourceNamespace { get; private set; }
        public INamespaceSymbol RRCGBuildNamespace { get; private set; }

        // Public references to known attribute type symbols
        public INamedTypeSymbol VariableAttribute { get; private set; }
        public INamedTypeSymbol SyncedVariableAttribute { get; private set; }
        public INamedTypeSymbol CloudVariableAttribute { get; private set; }
        public INamedTypeSymbol EventFunctionAttribute { get; private set; }
        public INamedTypeSymbol SharedPropertyAttribute { get; private set; }

        public BuildRealmResolver(SemanticModel semanticModel)
        {
            SemanticModel = semanticModel;

            // Populate SourceToBuildRealmType with known mappings.
            // Predefined types..
            AddTypeMetadataNameMapping("System.Boolean", "RRCGBuild.BoolPort");
            AddTypeMetadataNameMapping("System.String", "RRCGBuild.StringPort");
            AddTypeMetadataNameMapping("System.Int32", "RRCGBuild.IntPort");
            AddTypeMetadataNameMapping("System.Single", "RRCGBuild.FloatPort");
            AddTypeMetadataNameMapping("System.Void", "System.Void");

            // Existing class types..
            AddTypeMetadataNameMapping("System.Collections.Generic.List`1", "RRCGBuild.ListPort`1");
            AddTypeMetadataNameMapping("UnityEngine.Color", "RRCGBuild.ColorPort");
            AddTypeMetadataNameMapping("UnityEngine.Vector3", "RRCGBuild.Vector3Port");
            AddTypeMetadataNameMapping("UnityEngine.Quaternion", "RRCGBuild.QuaternionPort");

            // RRCG builder types...
            AddTypeMetadataNameMapping("RRCGSource.CircuitDescriptor", "RRCGBuild.CircuitBuilder");
            AddTypeMetadataNameMapping("RRCGSource.CircuitLibrary", "RRCGBuild.CircuitLibraryBuilder");
            AddTypeMetadataNameMapping("RRCGSource.Chips", "RRCGBuild.ChipBuilder");

            // Implemented RR types..
            foreach (var type in RRTypesUtils.ImplemetedRRTypes)
            {
                // A couple of these are already handled above.
                // We don't want these ones..
                if (type == "Color" || type == "Vector3" || type == "Quaternion") continue;

                AddTypeMetadataNameMapping($"RRCGSource.{type}", $"RRCGBuild.{type}Port");
            }

            // Store references to the RRCGSource/RRCGBuild namespaces..
            // (this should throw if they don't exist..)
            var allNamespaces = Compilation.GlobalNamespace.GetNamespaceMembers();
            RRCGSourceNamespace = allNamespaces.First(n => n.MetadataName == "RRCGSource");
            RRCGBuildNamespace = allNamespaces.First(n => n.MetadataName == "RRCGBuild");

            // Store references to known attribute types..
            VariableAttribute = GetKnownTypeByMetadataName("RRCGSource.Variable");
            SyncedVariableAttribute = GetKnownTypeByMetadataName("RRCGSource.SyncedVariable");
            CloudVariableAttribute = GetKnownTypeByMetadataName("RRCGSource.CloudVariable");

            EventFunctionAttribute = GetKnownTypeByMetadataName("RRCGSource.EventFunction");
            SharedPropertyAttribute = GetKnownTypeByMetadataName("RRCGSource.SharedProperty");
        }

        /// <summary>
        /// Given an ITypeSymbol, attempt to resolve its corresponding
        /// build-realm type. Result will be null if this fails.
        /// </summary>
        public ITypeSymbol? ResolveBuildRealmType(ITypeSymbol sourceRealm)
        {
            // Do we already happen to know which build type this maps to?
            if (SourceToBuildRealmType.TryGetValue(sourceRealm, out var cached))
                return cached;

            // Otherwise, we'll try to find it.
            // Get the metadata name of the type, and
            // adjust it to point into the RRCGBuild namespace.
            var metadataName = sourceRealm.GetMetadataName();
            if (metadataName.StartsWith("RRCGSource."))
                metadataName = metadataName.Substring("RRCGSource.".Length);

            metadataName = $"RRCGBuild.{metadataName}";

            // Now see if such a type exists in the compilation
            var resolved = Compilation.GetTypeByMetadataName(metadataName);
            if (resolved != null)
            {
                // Store it in our cache, and return to the caller.
                SourceToBuildRealmType[sourceRealm] = resolved;
                return resolved;
            }

            // We weren't able to resolve it.. sorry.
            return null;
        }

        /// <summary>
        /// Given a source-realm type symbol, create a TypeSyntax
        /// that refers to the same type in the build realm.
        /// </summary>
        public TypeSyntax RewriteBuildRealmNamespace(ITypeSymbol sourceRealm)
        {
            if (sourceRealm is IErrorTypeSymbol)
                throw new Exception("Got an IErrorTypeSymbol!");

            // Unpack the type symbol into a list of ancestors leading down to it
            var unpacked = sourceRealm.UnpackSymbolParents();
            if (unpacked.Count <= 0)
                throw new Exception("Attempt to re-write empty type?");

            // If the topmost symbol refers to the RRCGSource namespace,
            // replace it with the RRCGBuild namespace.
            //
            // In theory, we should be doing this for every user type, but
            // it's very difficult to determine if a particular type
            // is a user class, or a non-RRCG type (e.g. System.Action)
            //
            // But because we're rewriting all RRCG user class declarations into the
            // RRCGBuild namespace anyway, we technically don't need the fully-qualified name
            // (thought it'd be nice to have the hint), and we can just let C# infer the class for us.

            if (unpacked[0] == RRCGSourceNamespace)
                unpacked[0] = RRCGBuildNamespace;

            // Concatenate and re-parse into a type.
            return ParseTypeName(
                string.Join('.', unpacked.Select(
                    t => t.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat))));
        }

        /// <summary>
        /// Given a source-realm type symbol, attempt to resolve its corresponding
        /// build-realm type, but fallback to rewriting it into the RRCGBuild namespace.
        /// 
        /// Suitable for types that may refer to a Port type,
        /// but may also refer to a user-defined class.
        /// 
        /// This method recursively processes the input type, so it is safe
        /// to use for generic/tuple/array types too.
        /// </summary>
        public TypeSyntax ResolveOrRewriteBuildRealmType(ITypeSymbol sourceRealm)
        {
            if (sourceRealm is IErrorTypeSymbol)
                throw new Exception("Got an IErrorTypeSymbol!");

            // If the type is an array/tuple/generic type,
            // we have to do some special handling.
            if (sourceRealm is IArrayTypeSymbol array)
                return ResolveOrRewriteArrayBuildRealmType(array);
            else if (sourceRealm.IsTupleType)
                return ResolveOrRewriteTupleBuildRealmType((INamedTypeSymbol)sourceRealm);
            else if (sourceRealm is INamedTypeSymbol named && named.IsGenericType)
                return ResolveOrRewriteGenericBuildRealmType(named);

            // For type parameters, we should just pass-through,
            // so we avoid generating garbled syntax.
            if (sourceRealm is ITypeParameterSymbol typeParam)
                return ParseTypeName(typeParam.Name);

            // Otherwise, can we resolve the type to an existing build-realm type?
            if (ResolveBuildRealmType(sourceRealm) is ITypeSymbol resolved)
                return resolved.ToTypeSyntax();

            // If not, fallback to rewriting it into the RRCGBuild namespace.
            return RewriteBuildRealmNamespace(sourceRealm);
        }

        /// <summary>
        /// Given a source-realm array type, create a new ArrayTypeSyntax
        /// with a rewritten/resolved element type, preserving the array rank.
        /// </summary>
        private TypeSyntax ResolveOrRewriteArrayBuildRealmType(IArrayTypeSymbol sourceRealm)
        {
            var elementType = ResolveOrRewriteBuildRealmType(sourceRealm.ElementType);
            return ArrayType(elementType, SingletonList(
                                            ArrayRankSpecifier(
                                                SeparatedList<ExpressionSyntax>(
                                                    SyntaxUtils.CommaSeparated(
                                                        Enumerable.Repeat<SyntaxNodeOrToken>(
                                                            OmittedArraySizeExpression(), sourceRealm.Rank))))));
        }

        /// <summary>
        /// Given a source-realm tuple type, create a new TupleTypeSyntax
        /// with resolved/rewritten subtypes, preserving their identifiers.
        /// </summary>
        private TypeSyntax ResolveOrRewriteTupleBuildRealmType(INamedTypeSymbol sourceRealm)
        {
            return TupleType(
                SeparatedList<TupleElementSyntax>(
                    SyntaxUtils.CommaSeparated(
                        sourceRealm.TupleElements.Select(
                            e => (SyntaxNodeOrToken)TupleElement(ResolveOrRewriteBuildRealmType(e.Type), Identifier(e.Name))))));
        }

        /// <summary>
        /// Given a source-realm generic type symbol, resolve/rewrite its outer type,
        /// and recursively resolve/rewrite its type parameters.
        /// </summary>
        private TypeSyntax ResolveOrRewriteGenericBuildRealmType(INamedTypeSymbol sourceRealm)
        {
            // Attempt to resolve or re-write the original definition.
            var originalDefinition = sourceRealm.OriginalDefinition;
            var buildRealm = ResolveBuildRealmType(originalDefinition)?.ToTypeSyntax() ??
                             RewriteBuildRealmNamespace(originalDefinition);

            // We expect to find a GenericNameSyntax at the end..
            var genericName = GetGenericName(buildRealm);
            if (genericName == null)
                throw new Exception($"Could not find the GenericNameSyntax for resolved/rewritten build-realm type: {buildRealm}");

            // Now process its type parameters
            var newGenericName = genericName.WithTypeArgumentList(
                SyntaxUtils.TypeArgumentList(
                    sourceRealm.TypeArguments.Select(t => ResolveOrRewriteBuildRealmType(t)).ToArray()));

            // Finally, return the fully-resolved/rewritten name,
            // by replacing the original genericName with the new one.
            return buildRealm.ReplaceNode(genericName, newGenericName);
        }

        /// <summary>
        /// Given a potentially-fully-qualified TypeSyntax (which you expect to
        /// contain a GenericNameSyntax), walk along it to the end and extract 
        /// the GenericNameSyntax from it.
        /// </summary>
        static GenericNameSyntax? GetGenericName(TypeSyntax type)
        {
            // If the input type is already a generic name, return it
            if (type is GenericNameSyntax generic) return generic;

            // Otherwise, if the type is fully-qualified, we expect to find the
            // generic name at the very end, so we follow the Right path down.
            if (type is QualifiedNameSyntax qualified)
                return GetGenericName(qualified.Right);

            return null;
        }

        /// <summary>
        /// Utility to add a source type -> build type mapping by metadata names.
        /// Only used in construction (as of now)
        /// </summary>
        void AddTypeMetadataNameMapping(string sourceName, string buildName)
        {
            var sourceType = Compilation.GetTypeByMetadataName(sourceName);
            var buildType = Compilation.GetTypeByMetadataName(buildName);

            if (sourceType == null) throw new Exception($"Source type did not resolve: {sourceName}");
            if (buildType == null) throw new Exception($"Build type did not resolve: {buildName}");

            SourceToBuildRealmType[sourceType] = buildType;
        }

        /// <summary>
        /// Utility to get a known type from the compilation by metadata name.
        /// Only used in construction (as of now)
        /// </summary>
        INamedTypeSymbol GetKnownTypeByMetadataName(string metadataName)
        {
            var type = Compilation.GetTypeByMetadataName(metadataName);
            if (type == null) throw new Exception($"Type did not resolve: {metadataName}");

            return type;
        }
    }
}
#nullable disable