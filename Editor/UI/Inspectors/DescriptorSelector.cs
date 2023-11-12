using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace RRCG
{
    internal class DescriptorSelector
    {
        private bool ShowDescriptors = false;
        private Dictionary<string, List<string>> DescriptorOptions = new Dictionary<string, List<string>>();

        private string DisplayName;

        private Func<Dictionary<string, List<string>>> fetchOptions;

        internal DescriptorSelector(string displayName, Func<Dictionary<string, List<string>>> fetchOptions)
        {
            this.DisplayName = displayName;
            this.fetchOptions = fetchOptions;
        }

        internal bool Draw(RRCGCircuit rrcgMeta)
        {
            if (ShowDescriptors)
            {
                GUILayout.Label("Available "+ DisplayName + "s: ");

                foreach (var assembly in DescriptorOptions)
                {
                    GUILayout.Label(assembly.Key);

                    foreach (var className in assembly.Value)
                    {
                        if (GUILayout.Button(className.Replace("RRCGBuild.", "")))
                        {
                            rrcgMeta.Assembly = assembly.Key;
                            rrcgMeta.DescriptorClass = className;
                            Undo.RecordObject(rrcgMeta, "Configure RRCG "+ DisplayName);
                            PrefabUtility.RecordPrefabInstancePropertyModifications(rrcgMeta);
                            EditorUtility.SetDirty(rrcgMeta);
                            ShowDescriptors = false;
                        }
                    }
                }

                GUILayout.Space(10);
                if (GUILayout.Button("Cancel"))
                {
                    ShowDescriptors = false;
                }

                return true;
            }


            GUILayout.Label(DisplayName);
            GUILayout.BeginHorizontal();
            if (rrcgMeta.DescriptorClass != null)
            {
                GUILayout.Label(rrcgMeta.DescriptorClass);
            }
            if (GUILayout.Button("Select..."))
            {
                DescriptorOptions = fetchOptions();
                ShowDescriptors = true;
            }
            GUILayout.EndHorizontal();

            return false;
        }
    }
}
