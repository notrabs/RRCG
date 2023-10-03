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
}