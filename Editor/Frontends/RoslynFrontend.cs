using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using UnityEditor;
using UnityEngine;
using RRCGBuild;
using System.IO;
using System.Linq;

namespace RRCG
{
    public class RoslynFrontend
    {
        public static void Compile(RRCG rrcgMeta)
        {
            TextAsset csFile = rrcgMeta.RoomCircuit;
            string code = csFile.text;

            SyntaxTree sourceTree = CSharpSyntaxTree.ParseText(code);

            var rewriter = new RRCGSytaxRewriter();
            var generatedTree = rewriter.Visit(sourceTree.GetRoot());

            var generatedAssetPath = AssetDatabase.GetAssetPath(csFile).Replace(".cs", ".generated.cs");

            RRCGUtils.WriteGeneratedCode(generatedTree, generatedAssetPath);
        }

        public static Context GetBuilt(RRCG rrcgMeta)
        {
            Debug.Log("Building: " + rrcgMeta.RoomCircuit.name + "Gen");
            var type = GetType(rrcgMeta.RoomCircuit.name + "Gen");
            var instance = Activator.CreateInstance(type);
            var method = type.GetMethod("BuildCircuitGraph");
            return (Context)method.Invoke(instance, null);
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
