using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;

namespace RRCG.Projects
{
    public class RoslynProjectCompiler
    {
        /// <summary>
        /// Compiles and builds a standalone project
        /// </summary>
        public static async Task<string> CompileAndLoadProject(string projectName)
        {
            var totalTimer = new ProfilingTimer();

            var buildSyntaxTrees = await CompileProject(projectName);

            var assemblyName = BuildAndLoad(projectName, buildSyntaxTrees);

            Debug.Log($"RRCG Project Compile And Build completed in {totalTimer.Formatted}");

            return assemblyName;
        }

        /// <summary>
        /// Builds the cached files (This should not be needed, once the compile step can cache results)
        /// </summary>
        public static async void BuildProject(string projectName)
        {
            var totalTimer = new ProfilingTimer();
            var stepTimer = new ProfilingTimer();

            var projectDirectory = StandaloneProjectManager.GetProjectPath(projectName);
            var projectFiles = Directory.GetFiles(projectDirectory).Where(file => file.EndsWith(".rrcg.gen.cs")).ToArray();
            var readFiles = await Task.WhenAll(projectFiles.Select(file => File.ReadAllTextAsync(file)).ToArray());
            var buildSyntaxTrees = readFiles.Select((text, i) => CSharpSyntaxTree.ParseText(text, path: Path.GetFileName(projectFiles[i])));

            Debug.Log($"Loaded Build Files in {stepTimer.StartNew()}");

            BuildAndLoad(projectName, buildSyntaxTrees);

            Debug.Log($"RRCG Build completed in {totalTimer.Formatted}");
        }

        private static async Task<IEnumerable<SyntaxTree>> CompileProject(string projectName)
        {
            var stepTimer = new ProfilingTimer();

            var projectDirectory = StandaloneProjectManager.GetProjectPath(projectName);
            var projectFiles = Directory.GetFiles(projectDirectory, "*.rrcg.cs", SearchOption.AllDirectories);

            // Assume that if a .gen file is newer, that it is cached properly.
            // Would be nicer with some kind of hashing, but this allows you to tinker with .gen files too.
            var cachedSourceFiles = projectFiles.Where(sourceFile =>
            {
                var generatedFile = sourceFile.Replace(".rrcg.cs", ".rrcg.gen.cs");
                return File.Exists(generatedFile) && File.GetLastWriteTime(generatedFile) > File.GetLastWriteTime(sourceFile);
            });
            var filesToCompile = projectFiles.Except(cachedSourceFiles).ToArray();

            // Read all text data
            var cachedFilesText = await Task.WhenAll(cachedSourceFiles.Select(file => File.ReadAllTextAsync(file.Replace(".rrcg.cs", ".rrcg.gen.cs"))).ToArray());
            var filesToCompileText = await Task.WhenAll(filesToCompile.Select(file => File.ReadAllTextAsync(file)).ToArray());

            // Parse the scripts
            var options = CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.CSharp9);
            var cachedSyntaxTrees = cachedFilesText.Select(text => CSharpSyntaxTree.ParseText(text, options)).ToArray();
            var sourceSyntaxTrees = filesToCompileText.Select(text => CSharpSyntaxTree.ParseText(text, options)).ToArray();

            // Prepare the semantic model
            var compilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
            var sourceCompilation = CSharpCompilation.Create(
                "RRCG.SemanticModel",
                // Add at least an empty syntax tree, so the Compilation gets the CSharp9 version. 
                // This seems to be the only way to configure it
                new SyntaxTree[] { CSharpSyntaxTree.ParseText("", options) },
                RoslynFrontend.GetLoadedReferences(),
                compilationOptions
            );

            // Rewrite the Syntax Nodes
            var buildSyntaxNodes = sourceSyntaxTrees.Select((sourceTree) => RoslynFrontend.RewriteRRCGSource(sourceTree, sourceCompilation).NormalizeWhitespace()).ToArray();
            var buildCodeTexts = buildSyntaxNodes.Select((node) => node.ToString()).ToArray();
            var buildCodePaths = buildSyntaxNodes.Select((node, index) => filesToCompile[index].Replace(".rrcg.cs", ".rrcg.gen.cs")).ToArray();

            // The cache files can be written async, since they are not read again
            foreach (var (i, buildCodeText) in buildCodeTexts.Select((value, i) => (i, value))) _ = File.WriteAllTextAsync(buildCodePaths[i], buildCodeText);

            // Reparse All Scripts, because rewriting does not preserve the language version
            var buildSyntaxTrees = buildCodeTexts.Select((text, i) => CSharpSyntaxTree.ParseText(text, options, path: buildCodePaths[i])).ToArray();

            Debug.Log($"Compiled Source Files in {stepTimer.StartNew()} ({cachedSyntaxTrees.Count()}/{cachedSyntaxTrees.Count() + sourceSyntaxTrees.Count()} cached)");

            return cachedSyntaxTrees.Concat(buildSyntaxTrees);
        }

        static int assemblyCounter = 0;

        private static string BuildAndLoad(string projectName, IEnumerable<SyntaxTree> buildSyntaxTrees)
        {
            var stepTimer = new ProfilingTimer();

            var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);

            var references = new[] {
                //MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                //MetadataReference.CreateFromFile(typeof(ExpandoObject).Assembly.Location),
                MetadataReference.CreateFromFile(Assembly.Load(new AssemblyName("Microsoft.CSharp")).Location),
                //MetadataReference.CreateFromFile(Assembly.Load(new AssemblyName("netstandard")).Location),
                MetadataReference.CreateFromFile(Assembly.Load(new AssemblyName("mscorlib")).Location),
                //MetadataReference.CreateFromFile(Assembly.Load(new AssemblyName("System.Runtime")).Location),
            };

            var assemblyName = $"RRCG.Hot.{projectName}.{assemblyCounter++}";

            var compilation = CSharpCompilation.Create(assemblyName, buildSyntaxTrees, references.Concat(RoslynFrontend.GetLoadedReferences()), options);

            var stream = new MemoryStream();
            var result = compilation.Emit(stream);

            Debug.Log($"Emitted Assembly in {stepTimer.StartNew()}");

            if (!result.Success)
            {
                foreach (var diagnostic in result.Diagnostics)
                {
                    if (diagnostic.Severity == DiagnosticSeverity.Error) Debug.LogError(diagnostic.ToString());
                    else if (diagnostic.Severity == DiagnosticSeverity.Warning) Debug.LogWarning(diagnostic.ToString());
                    else Debug.Log(diagnostic.ToString());
                }

                throw new Exception("RRCG Project compilation failed");
            }

            var bytes = stream.ToArray();

            Assembly.Load(bytes);

            Debug.Log($"Loaded Assembly in {stepTimer.StartNew()}");

            return assemblyName;
        }
    }
}
