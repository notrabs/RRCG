using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using RRCG;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;
using RRCG.Projects;

namespace Packages.RRCG.Editor.Projects
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
            var projectFiles = Directory.GetFiles(projectDirectory).Where(file => file.EndsWith(".rrcg.cs")).ToArray();

            var readFiles = await Task.WhenAll(projectFiles.Select(file => File.ReadAllTextAsync(file)).ToArray());

            var options = CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.CSharp9);
            var sourceSyntaxTrees = readFiles.Select(text => CSharpSyntaxTree.ParseText(text, options));

            var sourceCompilation = CSharpCompilation.Create("RRCG.SemanticModel", sourceSyntaxTrees, RoslynFrontend.GetLoadedReferences());

            var buildSyntaxNodes = sourceSyntaxTrees.Select((sourceTree) => RoslynFrontend.RewriteRRCGSource(sourceTree, sourceCompilation));

            foreach (var (i, buildSyntaxNode) in buildSyntaxNodes.Select((value, i) => (i, value)))
            {
                string generatedCode = buildSyntaxNode.NormalizeWhitespace().ToString();
                var debugOutputPath = projectFiles[i].Replace(".rrcg.cs", ".rrcg.gen.cs");
                _ = File.WriteAllTextAsync(debugOutputPath, generatedCode);
            }

            Debug.Log($"Compiled Source Files in {stepTimer.StartNew()}");

            return buildSyntaxNodes.Select((node, i) => node.SyntaxTree.WithFilePath(Path.GetFileName(projectFiles[i].Replace(".rrcg.cs", ".rrcg.gen.cs"))));
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
