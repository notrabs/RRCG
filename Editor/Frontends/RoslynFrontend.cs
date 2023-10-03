using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using UnityEditor;
using UnityEngine;
using RRCGBuild;
using System.IO;

namespace RRCG
{
    public class RoslynFrontend
    {
        public static void Compile(string sourcePath, string compiledPath)
        {
            string code = File.ReadAllText(sourcePath);

            SyntaxTree sourceTree = CSharpSyntaxTree.ParseText(code);

            var compilation = CSharpCompilation.Create("RRCG.SemanticModel", syntaxTrees: new[] { sourceTree });
            var semanticModel = compilation.GetSemanticModel(sourceTree);

            var rewriter = new RRCGSyntaxRewriter(semanticModel);
            var generatedTree = rewriter.Visit(sourceTree.GetRoot());

            FileUtils.WriteGeneratedCode(generatedTree, compiledPath);
        }

        public static Context GetBuilt(RRCG rrcgMeta)
        {
            Debug.Log("Building: " + rrcgMeta.RoomCircuitClass);
            var type = Utils.GetTypeInAssembly(rrcgMeta.RoomCircuitAssembly, rrcgMeta.RoomCircuitClass);

            if (type == null) throw new Exception("Could not find compiled class for '" + rrcgMeta.RoomCircuitClass + "'. Make sure the class is public in the root namespace and has the same name as its file.");

            Context context = new Context();

            Context.current = context;
            ExecFlow.current = new ExecFlow();
            ConditionalContext.Push(new RootConditionalContext());

            var instance = (CircuitBuilder)Activator.CreateInstance(type);
            instance.CircuitGraph();

            ConditionalContext.Clear();
            ExecFlow.current = null;
            Context.current = null;

            return context;
        }
    }
}
