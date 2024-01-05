using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using UnityEditor;
using UnityEngine;
using RRCGBuild;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using RRCG.Projects;
using System.Threading.Tasks;

namespace RRCG
{
    public class RoslynFrontend
    {
        public static void CompileFile(string sourcePath, string compiledPath)
        {
            string code = File.ReadAllText(sourcePath);
            SyntaxTree sourceTree = ParseText(code);

            // Create compilation with references to all loaded assemblies
            var compilation = CSharpCompilation.Create(
                "RRCG.SemanticModel",
                // We don't know which other files to reference, so the compilation will only know one file at the time.
                new[] { sourceTree },
                GetLoadedReferences()
            );

            var generatedTree = RewriteRRCGSource(sourceTree, compilation);

            FileUtils.WriteGeneratedCode(generatedTree, compiledPath);
        }

        public static SyntaxTree ParseText(string text) => ParseText(text, null); // Single Parameter overload to use in Linq
        public static SyntaxTree ParseText(string text, string path)
        {
            // The language version used by RRCG (and Unity)
            var options = CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.CSharp9);
            return CSharpSyntaxTree.ParseText(text, options, path);
        }

        public static IEnumerable<PortableExecutableReference> GetLoadedReferences()
        {
            return AppDomain.CurrentDomain.GetAssemblies().Select(
                 a =>
                 {
                     // RRCG.Hot dlls are not loaded from files (yet).
                     if (a.FullName.StartsWith("RRCG.Hot")) return null;
                     try { return MetadataReference.CreateFromFile(a.Location); }
                     catch (NotSupportedException) { return null; } // dynamic assemblies
                 }
             ).Where(a => a != null);
        }

        public static SyntaxNode RewriteRRCGSource(SyntaxTree sourceTree, CSharpCompilation compilation)
        {
            var rewriter = new RRCGSyntaxRewriter(compilation.GetSemanticModel(sourceTree));
            return rewriter.Visit(sourceTree.GetRoot());
        }

        public static async Task<Context> GetBuilt(RRCGCircuit rrcgMeta)
        {
            if (!string.IsNullOrEmpty(rrcgMeta.Assembly)) return GetBuilt(rrcgMeta.Assembly, rrcgMeta.DescriptorClass);

            var assemblyName = await RoslynProjectCompiler.CompileAndLoadProject(rrcgMeta.Project);

            return GetBuilt(assemblyName, rrcgMeta.DescriptorClass);
        }

        public static Context GetBuilt(string assembly, string descriptorClass)
        {
            Debug.Log("Building: " + descriptorClass);
            var type = Utils.GetTypeInAssembly(assembly, descriptorClass);

            if (type == null) throw new Exception("Could not find compiled class for '" + descriptorClass + "'. Make sure the class is public in the root namespace and has the same name as its file.");

            SemanticStack.current = new SemanticStack();
            Context context = new Context();

            Context.current = context;
            ExecFlow.current = new ExecFlow(); // exec flow for initializers

            var instance = (CircuitBuilder)Activator.CreateInstance(type);

            ExecFlow.current = new ExecFlow(); // exec flow for main graph
            instance.CircuitGraph();

            var additionalCircuitGraphs = instance.GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).Where(m => m.GetCustomAttribute<CircuitGraph>() != null);
            foreach (var method in additionalCircuitGraphs)
            {
                ExecFlow.current = new ExecFlow();
                method.Invoke(instance, new object[0]);
            }

            ExecFlow.current = null;
            Context.current = null;

            if (SemanticStack.current.Count() > 0) Debug.LogWarning("Expected SemanticStack to be empty at end of compilation");

            return context;
        }

        public static async Task UpdateRRO(RRCGStudioObject rrcgMeta)
        {
            if (!string.IsNullOrEmpty(rrcgMeta.Assembly)) UpdateRRO(rrcgMeta.Assembly, rrcgMeta.DescriptorClass, rrcgMeta.gameObject);

            var assemblyName = await RoslynProjectCompiler.CompileAndLoadProject(rrcgMeta.Project);

            UpdateRRO(assemblyName, rrcgMeta.DescriptorClass, rrcgMeta.gameObject);
        }

        public static void UpdateRRO(string assembly, string descriptorClass, GameObject gameObject)
        {
            var type = Utils.GetTypeInAssembly(assembly, descriptorClass);

            var instance = (StudioObjectBuilder)Activator.CreateInstance(type, new object[] { new StudioObjectPort() { Data = gameObject } });
            instance.__UpdateStudioEvents();
        }
    }
}
