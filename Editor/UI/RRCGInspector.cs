using UnityEngine;
using UnityEditor;
using System;
using System.Linq;
using System.Collections.Generic;
using UnityEditor.Experimental;
using RRCG.Optimizer;

namespace RRCG
{
    [CustomEditor(typeof(RRCG))]
    public class RRCGInpsector : Editor
    {
        public static bool EnableOptimizer = true;

        private bool ShowCircuitDescriptors = false;
        private Dictionary<string, List<string>> CircuitDescriptorOptions = new Dictionary<string, List<string>>();

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            RRCG rrcgMeta = (RRCG)target;

            if (ShowCircuitDescriptors)
            {
                GUILayout.Label("Available Circuit Descriptors: ");

                foreach (var assembly in CircuitDescriptorOptions)
                {
                    GUILayout.Label(assembly.Key);

                    foreach (var className in assembly.Value)
                    {
                        if (GUILayout.Button(className.Replace("RRCGBuild.", "")))
                        {
                            rrcgMeta.RoomCircuitAssembly = assembly.Key;
                            rrcgMeta.RoomCircuitClass = className;
                            Undo.RecordObject(rrcgMeta, "Configure RRCG CircuitDescriptor");
                            PrefabUtility.RecordPrefabInstancePropertyModifications(rrcgMeta);
                            EditorUtility.SetDirty(rrcgMeta);
                            ShowCircuitDescriptors = false;
                        }
                    }
                }

                GUILayout.Space(10);
                if (GUILayout.Button("Cancel"))
                {
                    ShowCircuitDescriptors = false;
                }

                return;
            }


            GUILayout.Label("Circuit Descriptor");
            GUILayout.BeginHorizontal();
            if (rrcgMeta.RoomCircuitClass != null)
            {
                GUILayout.Label(rrcgMeta.RoomCircuitClass);
            }
            if (GUILayout.Button("Select..."))
            {
                CircuitDescriptorOptions = Utils.GetAllAvailableCircuitDescriptors();
                ShowCircuitDescriptors = true;
            }
            GUILayout.EndHorizontal();

            GUILayout.Label("Compiler");

            //GUILayout.BeginHorizontal();
            //if (GUILayout.Button("Compile Room Circuit"))
            //{
            //    AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(rrcgMeta.RoomCircuit));
            //}
            //RRCGScriptPreprocessor.AutoCompile = GUILayout.Toggle(RRCGScriptPreprocessor.AutoCompile, "Watch", GUILayout.Width(70));
            //GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Build Circuits"))
            {
                Application.OpenURL("https://recroom.featureupvote.com/suggestions/482338/circuits-api");
                EditorUtility.DisplayDialog("WIP", "Please upvote this feature request :]\nTo bring the generated graphs into the game we need official support for programmatic circuit manipulation.", "Ok");
            }
            EnableOptimizer = GUILayout.Toggle(EnableOptimizer, "Optimize", GUILayout.Width(70));
            GUILayout.EndHorizontal();

            GUILayout.Label("Debug Graph");

            if (GUILayout.Button("Open DOT Visualizer"))
            {
                Application.OpenURL("https://dreampuf.github.io/GraphvizOnline/");
            }

            if (GUILayout.Button("Copy DOT Graph"))
            {
                var context = RoslynFrontend.GetBuilt(rrcgMeta);
                if (EnableOptimizer) context = GraphOptimizer.Optimize(context);
                DotGraphBackend.Build(context);
            }
        }
    }
}
