using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Packages.RRCG.Editor.Projects;
using RRCG;
using RRCG.Projects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnityEditor;

class Utils
{
    public static Task awaitNextTick()
    {
        var promise = new TaskCompletionSource<bool>();
        EditorApplication.delayCall += delegate ()
        {
            promise.SetResult(true);
        };
        return promise.Task;
    }

    public static Dictionary<string, List<string>> GetAllAvailableCircuitDescriptors()
    {
        return GetAllAvailableDescriptors("CircuitBuilder");
    }
    public static Dictionary<string, List<string>> GetAllAvailableStudioObjectDescriptors()
    {
        return GetAllAvailableDescriptors("StudioObjectBuilder");
    }

    public static Dictionary<string, List<string>> GetAllAvailableDescriptors(string name)
    {
        var descriptors = new Dictionary<string, List<string>>();

        foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
        {
            // RRCG.Hot assemblies should be used through the projects interface, not directly as they are only temporary assemblies.
            if (a.FullName.StartsWith("RRCG.Hot")) continue;

            List<string> classes = GetAllAvailableDescriptors(a, name);

            if (classes.Count > 0) descriptors.Add(a.GetName().Name, classes);
        }

        return descriptors;
    }


    public static List<string> GetAllAvailableDescriptors(Assembly assembly, string name)
    {
        List<string> classes = new List<string>();

        foreach (var t in assembly.GetTypes())
        {
            if (t.BaseType?.Name == name) classes.Add(t.FullName);
        }

        return classes;
    }

    public static async Task<List<string>> GetAllAvailableCircuitDescriptorsInProject(string projectName)
    {
        var assemblyName = await RoslynProjectCompiler.CompileAndLoadProject(projectName);
        var assembly = AppDomain.CurrentDomain.GetAssemblies().First(a => a.FullName.StartsWith(assemblyName));

        return GetAllAvailableDescriptors(assembly, "CircuitBuilder");
    }
    public static async Task<List<string>> GetAllAvailableStudioObjectDescriptorsInProject(string projectName)
    {
        var assemblyName = await RoslynProjectCompiler.CompileAndLoadProject(projectName);
        var assembly = AppDomain.CurrentDomain.GetAssemblies().First(a => a.FullName.StartsWith(assemblyName));

        return GetAllAvailableDescriptors(assembly, "StudioObjectBuilder");
    }

    public static Type GetTypeInAssembly(string assemblyName, string typeName)
    {
        foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
        {
            if (a.GetName().Name == assemblyName)
            {
                var type = a.GetType(typeName);
                if (type != null)
                    return type;

                throw new Exception("Did not the RRCG class: " + typeName + " (Make sure the CircuitDescriptor is correctly selected and try to Recompile all circuits in the RRCG window menu)");
            }
        }
        throw new Exception("Did not find assembly: " + assemblyName + " (Make sure the CircuitDescriptor is correctly selected)");
    }
}
