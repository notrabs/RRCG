using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Compilation;
using System.Reflection;
using System;
using RRCG;
using System.Threading;

[InitializeOnLoad]
static class DocumentationWriter
{
    static DocumentationWriter()
    {
        CompilationPipeline.compilationFinished += OnCompilationFinished;
    }

    private static void OnCompilationFinished(object _)
    {
        // NOTE: Ideally, the Unity C# compiler should be able to do this for us.
        //       The C# compiler supports a "/doc:file.xml" argument that writes
        //       the documentation to the desired file. But even adding it to the
        //       additional compiler arguments for the assemblies, I couldn't get this to work..
        //
        //       At some point we should revisit this. But for now, this solution works.

        var assemblies = CompilationPipeline.GetAssemblies();
        foreach (var asm in assemblies)
        {
            // Use defines as a way for assemblies to opt-in to documentation generation
            if (!asm.defines.Contains("RRCG_WRITE_XML_DOC")) continue;

            // Create a compilation for the assembly
            var compilation = CSharpCompilation.Create(
                asm.name,
                asm.sourceFiles.Select(path => RoslynFrontend.ParseText(File.ReadAllText(path), path, asm.defines)),
                asm.allReferences.Select(path => MetadataReference.CreateFromFile(path))
            );

            // Generate & write the documentation XML,
            // in the same directory as the output dll.
            //
            // ASSUMPTION: Unity should have already created the directories
            //             leading up to this path.
            var outputXml = asm.outputPath.Replace(".dll", ".xml");

            using (var fileStream = File.Create(outputXml))
            {
                // This is really, really not ideal.
                var documentationCommentCompiler = Type.GetType("Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler, Microsoft.CodeAnalysis.CSharp");
                var writeDocumentationCommentXml = documentationCommentCompiler.GetMethod("WriteDocumentationCommentXml", BindingFlags.Public | BindingFlags.Static);

                writeDocumentationCommentXml.Invoke(null, new object[] { compilation, asm.name, fileStream, null, CancellationToken.None, null, null });
            }
        }
    }
}