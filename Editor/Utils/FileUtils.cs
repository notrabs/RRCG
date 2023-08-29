using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;

class FileUtils
{
    public static void WriteGeneratedCode(SyntaxNode syntaxTree, string path)
    {
        string generatedCode = syntaxTree.NormalizeWhitespace().ToString();

        var file = File.CreateText(path);
        file.Write(generatedCode);
        file.Close();

        AssetDatabase.ImportAsset(path);
    }
}
