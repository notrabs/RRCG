using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Compilation;

namespace RRCG
{
    [InitializeOnLoad]
    public class RRCGScriptPreprocessor : AssetPostprocessor
    {
        /// <summary>Paths to RRCG files we should compile in the next Unity compilation.</summary>
        static List<string> CompileRRCGFiles = new();

        public static bool AutoCompile
        {
            get => EditorPrefs.GetBool("RRCG_USE_SCRIPT_POSTPROCESSOR", true);
            set => EditorPrefs.SetBool("RRCG_USE_SCRIPT_POSTPROCESSOR", value);
        }

        static RRCGScriptPreprocessor()
        {
            CompilationPipeline.compilationStarted += OnCompilationStarted;
        }

        protected void OnPreprocessAsset()
        {
            if (!AutoCompile) return;
            if (!assetPath.EndsWith(".rrcg.cs")) return;

            // Queue the file for compilation, and request script compilation.
            CompileRRCGFiles.Add(assetPath);
            CompilationPipeline.RequestScriptCompilation();
        }

        private static void OnCompilationStarted(object obj)
        {
            var assemblies = CompilationPipeline.GetAssemblies();

            foreach (var asm in assemblies)
            {
                // Does this assembly contain any source files to compile?
                var filesToCompile = asm.sourceFiles.Intersect(CompileRRCGFiles).ToArray();
                if (filesToCompile.Length <= 0) continue;

                // Determine which files to include in the compilation.
                // RRCG will re-write the files in filesToCompile, but for
                // a full semantic model, we need to include the other C# files too.
                var rrcgFiles = asm.sourceFiles.Where(f => f.EndsWith(".rrcg.cs"));
                var nonRRCGFiles = asm.sourceFiles.Where(f => !f.EndsWith(".rrcg.cs") && !f.EndsWith(".rrcg.gen.cs"));
                var filesToIncludeNotCompile = rrcgFiles.Except(filesToCompile).Concat(nonRRCGFiles);

                // Parse syntax trees, and create a compilation.
                var compileSyntaxTrees = filesToCompile.Select(File.ReadAllText).Select(RoslynFrontend.ParseText).ToArray();
                var otherSyntaxTrees = filesToIncludeNotCompile.Select(File.ReadAllText).Select(RoslynFrontend.ParseText).ToArray();

                var compilation = CSharpCompilation.Create(
                    asm.name,
                    compileSyntaxTrees.Concat(otherSyntaxTrees),
                    asm.allReferences.Select(r => MetadataReference.CreateFromFile(r))
                );

                // Now, we can rewrite the source, and write to their generated files.
                var buildSyntaxNodes = compileSyntaxTrees.Select(t => RoslynFrontend.RewriteRRCGSource(t, compilation).NormalizeWhitespace());
                var buildCodeTexts = buildSyntaxNodes.Select(n => n.ToString()).ToArray();
                var buildCodePaths = buildSyntaxNodes.Select((node, index) => filesToCompile[index].Replace(".rrcg.cs", ".rrcg.gen.cs")).ToArray();

                if (buildCodePaths.Length != buildCodeTexts.Length)
                    throw new Exception("Number of file paths vs number of built syntax trees doesn't match?");

                var buildCodePathsToText = buildCodePaths.Zip(buildCodeTexts, (t, p) => (t, p));

                foreach ((var path, var text) in buildCodePathsToText)
                    File.WriteAllText(path, text);

                // Remove the newly-compiled files from the queue.
                foreach (var file in filesToCompile)
                    CompileRRCGFiles.Remove(file);
            }
        }
    }
}
