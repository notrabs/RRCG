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

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            RRCG rrcgMeta = (RRCG)target;

            GUILayout.Label("Compiler");

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Compile Circuits"))
            {
                RoslynFrontend.Compile(rrcgMeta);
            }
            RRCGScriptPreprocessor.AutoCompile = GUILayout.Toggle(RRCGScriptPreprocessor.AutoCompile, "Watch", GUILayout.Width(70));
            GUILayout.EndHorizontal();

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

    class RRCGScriptPreprocessor : AssetPostprocessor
    {
        public static bool AutoCompile = true;

        private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            if (!AutoCompile) return;

            var pathToRRCG = GameObject.FindObjectsOfType<RRCG>().Where(rrcg => rrcg.RoomCircuit != null).ToDictionary(rrcg => AssetDatabase.GetAssetPath(rrcg.RoomCircuit), rrcg => rrcg);

            foreach (var importedAsset in importedAssets)
            {
                if (pathToRRCG.TryGetValue(importedAsset, out RRCG rrcgMeta))
                {
                    try
                    {
                        RoslynFrontend.Compile(rrcgMeta);
                    }
                    catch (Exception ex)
                    {
                        Debug.LogException(ex);
                    }
                }
            }

            //if (!hasCompiled) EditorApplication.UnlockReloadAssemblies();
        }

        //protected void OnPreprocessAsset()
        //{
        //    if (!AutoCompile) return;

        //    var rrcgs = GameObject.FindObjectsOfType<RRCG>().Where(rrcg => rrcg.RoomCircuit != null);

        //    var rrcg = rrcgs.First();


        //    //EditorApplication.LockReloadAssemblies();
        //}

        //    protected void OnPreprocessAsset()
        //{
        //    if (!AutoCompile) return;

        //    var rrcgs = GameObject.FindObjectsOfType<RRCG>().Where(rrcg => rrcg.RoomCircuit != null);

        //    string assetGuid = AssetDatabase.AssetPathToGUID(assetPath);


        //    Debug.Log(assetGuid);
        //    Debug.Log(watchGUIDs[rrcgs.First()]);

        //    var rrcg = rrcgs.First();

        //    rrcg.

        //    var rrcgMeta = rrcgs.FirstOrDefault(rrcg => watchGUIDs.TryGetValue(rrcg, out string guid) && guid == assetGuid);

        //    Debug.Log(rrcgMeta);

        //    if (rrcgMeta != null) RoslynFrontend.Compile(rrcgMeta);
        //}
    }
}