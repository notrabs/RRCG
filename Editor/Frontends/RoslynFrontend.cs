using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using UnityEditor;
using UnityEngine;
using RRCGBuild;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RRCG
{
    public class RoslynFrontend
    {
        public static void Compile(string sourcePath, string compiledPath)
        {
            string code = File.ReadAllText(sourcePath);

            SyntaxTree sourceTree = CSharpSyntaxTree.ParseText(code);

            // Create compilation with references to all loaded assemblies
            var references = AppDomain.CurrentDomain.GetAssemblies().Select(
                a =>
                {
                    try { return MetadataReference.CreateFromFile(a.Location); }
                    catch (NotSupportedException) { return null; } // dynamic assemblies
                }
            ).Where(a => a != null);

            var compilation = CSharpCompilation.Create("RRCG.SemanticModel")
                .WithReferences(references);

            var rewriter = new RRCGSyntaxRewriter(compilation);
            var generatedTree = rewriter.Visit(sourceTree.GetRoot());

            FileUtils.WriteGeneratedCode(generatedTree, compiledPath);
        }

        public static Context GetBuilt(RRCGCircuit rrcgMeta)
        {
            return GetBuilt(rrcgMeta.Assembly, rrcgMeta.DescriptorClass);
        }

        public static Context GetBuilt(string assembly, string descriptorClass)
        {
            Debug.Log("Building: " + descriptorClass);
            var type = Utils.GetTypeInAssembly(assembly, descriptorClass);

            if (type == null) throw new Exception("Could not find compiled class for '" + descriptorClass + "'. Make sure the class is public in the root namespace and has the same name as its file.");

            SemanticStack.current = new SemanticStack();
            Context context = new Context();

            Context.current = context;
            ExecFlow.current = new ExecFlow();

            var instance = (CircuitBuilder)Activator.CreateInstance(type);
            instance.CircuitGraph();

            var additionalCircuitGraphs = instance.GetType().GetMethods().Where(m => m.GetCustomAttribute<CircuitGraph>() != null);
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

        public static void UpdateRRO(RRCGStudioObject rrcgMeta)
        {
            var type = Utils.GetTypeInAssembly(rrcgMeta.Assembly, rrcgMeta.DescriptorClass);

            var instance = (StudioObjectBuilder)Activator.CreateInstance(type, new object[] { new StudioObjectPort() { Data = rrcgMeta.gameObject } });
            instance.__UpdateStudioEvents();
        }
    }
}
