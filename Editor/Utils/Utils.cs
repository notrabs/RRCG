using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
            List<string> classes = new List<string>();

            foreach (var t in a.GetTypes())
            {
                if (t.BaseType?.Name == name)
                {
                    classes.Add(t.FullName);
                }
            }

            if (classes.Count > 0)
            {
                descriptors.Add(a.GetName().Name, classes);
            }
        }

        return descriptors;
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
