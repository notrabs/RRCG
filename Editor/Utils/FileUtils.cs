using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using UnityEditor;
using UnityEngine;

class FileUtils
{
    public static void WriteGeneratedCode(SyntaxNode syntaxTree, string path)
    {
        string generatedCode = syntaxTree.NormalizeWhitespace().ToString();

        File.WriteAllText(path, generatedCode);

        AssetDatabase.ImportAsset(path);
    }
}
