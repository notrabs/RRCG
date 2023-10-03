using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using UnityEditor;
using UnityEngine;
using RRCGBuild;

namespace RRCG
{
    public class RoslynFrontend
    {
        public static void Compile(RRCG rrcgMeta)
        {
            TextAsset csFile = rrcgMeta.RoomCircuit;
            string code = csFile.text;

            SyntaxTree sourceTree = CSharpSyntaxTree.ParseText(code);

            var compilation = CSharpCompilation.Create("RRCG.SemanticModel", syntaxTrees: new[] { sourceTree });
            var semanticModel = compilation.GetSemanticModel(sourceTree);

            var rewriter = new RRCGSytaxRewriter(semanticModel);
            var generatedTree = rewriter.Visit(sourceTree.GetRoot());

            var generatedAssetPath = AssetDatabase.GetAssetPath(csFile).Replace(".rrcg.cs", ".rrcg.gen.cs");

            FileUtils.WriteGeneratedCode(generatedTree, generatedAssetPath);
        }

        public static Context GetBuilt(RRCG rrcgMeta)
        {
            Debug.Log("Building: " + rrcgMeta.RoomCircuit.name + "Gen");
            var type = GetType(rrcgMeta.RoomCircuit.name + "Gen");

            if (type == null) throw new Exception("Could not find compiled class for '" + rrcgMeta.RoomCircuit.name + "'. Make sure the class is public in the root namespace and has the same name as its file.");

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

        public static Type GetType(string typeName)
        {
            var type = Type.GetType(typeName);
            if (type != null) return type;
            foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = a.GetType(typeName);
                if (type != null)
                    return type;
            }
            return null;
        }

    }
}
