using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEditor;

namespace RRCG.Projects
{
    // Utilities to create/read "standalone" projects, that bypass the unity compiler.
    public static class StandaloneProjectManager
    {
        public static string ProjectsPath => Path.GetFullPath("RRCG");

        public static string GetProjectPath(string projectName) => Path.Combine(ProjectsPath, projectName);

        public static IEnumerable<string> GetProjects()
        {
            if (!Directory.Exists(ProjectsPath)) return new string[0];
            return Directory.GetDirectories(ProjectsPath).Select(Path.GetFileName).Where(d => !d.StartsWith("."));
        }

        public static bool CreateNewProject(string name)
        {
            if (!Regex.IsMatch(name, "^[a-zA-Z][a-zA-Z0-9]*$"))
            {
                EditorUtility.DisplayDialog("Invalid Name", "The name must be a valid class name", "Ok");
                return false;
            }

            if (!Directory.Exists(ProjectsPath)) Directory.CreateDirectory(ProjectsPath);

            var projectPath = GetProjectPath(name);

            if (Directory.Exists(projectPath))
            {
                EditorUtility.DisplayDialog("Invalid Name", "Project already exists", "Ok");
                return false;
            }

            Directory.CreateDirectory(projectPath);

            File.WriteAllText(Path.Combine(projectPath, name + ".rrcg.cs"), InitialClassContent(name));

            RegenerateSolution();

            return true;
        }

        public static void RegenerateSolution()
        {
            if (!Directory.Exists(ProjectsPath)) return;

            var references = new Dictionary<string, string>();

            foreach (var reference in RoslynFrontend.GetLoadedReferences())
            {
                references.Add(reference.Display, reference.FilePath);
            }

            foreach (var project in GetProjects())
            {
                File.WriteAllText(Path.Combine(ProjectsPath, project, project + ".csproj"), ProjectFile(references));
            }

            File.WriteAllText(Path.Combine(ProjectsPath, "RRCG_Projects.sln"), SolutionFile());
        }

        public static void Clean()
        {
            if (!Directory.Exists(ProjectsPath)) return;
            var genFiles = Directory.GetFiles(ProjectsPath, "*.rrcg.gen.cs", SearchOption.AllDirectories);
            foreach (var genFile in genFiles) File.Delete(genFile);
        }

        //
        // Solution File Generation
        //

        static string InitialClassContent(string name)
        {
            return @$"
using RRCG;
using RRCGSource;
using UnityEngine;

public class {name} : CircuitDescriptor
{{
    public override void CircuitGraph()
    {{
        LogString(""Hello World"");
    }}
}}
";
        }

        static string SolutionFile()
        {
            string projectEntries = "";

            foreach (var project in GetProjects())
            {
                projectEntries += $@"

Project(""{{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}}"") = ""{project}"", ""./{project}/{project}.csproj"", ""{{{new GUID()}}}""
EndProject
";
            }

            return $@"

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.8.34330.188
MinimumVisualStudioVersion = 10.0.40219.1
{projectEntries}
Global
EndGlobal
";
        }

        static string ProjectFile(Dictionary<string, string> references)
        {
            var referenceItems = "";

            foreach (var reference in references)
            {
                referenceItems += @$"
    <Reference Include=""{reference.Key}"">
      <HintPath>{reference.Value}</HintPath>
    </Reference>";
            }


            return $@"
<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <AllowUnsafeBlocks>True</AllowUnsafeBlocks>
  </PropertyGroup>

  <ItemGroup>
{referenceItems}
  </ItemGroup>

</Project>
";
        }
    }
}
