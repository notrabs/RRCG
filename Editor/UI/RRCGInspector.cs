using UnityEngine;
using UnityEditor;

namespace RRCG
{
    [CustomEditor(typeof(RRCG))]
    public class RRCGInpsector : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            RRCG rrcgMeta = (RRCG)target;
            
            GUILayout.Label("Compiler");

            if (GUILayout.Button("Compile Circuits"))
            {
                RoslynFrontend.Compile(rrcgMeta);
            }

            if (GUILayout.Button("Build Circuits"))
            {
                Application.OpenURL("https://recroom.featureupvote.com/suggestions/482338/circuits-api");
                EditorUtility.DisplayDialog("WIP", "Please upvote this feature request :]\nTo bring the generated graphs into the game we need official support for programmatic circuit manipulation.", "Ok");
            }

            GUILayout.Label("Debug Graph");

            if (GUILayout.Button("Open DOT Visualizer"))
            {
                Application.OpenURL("https://dreampuf.github.io/GraphvizOnline/");
            }

            if (GUILayout.Button("Copy DOT Graph"))
            {
                var context = RoslynFrontend.GetBuilt(rrcgMeta);
                DotGraphBackend.Build(context);
            }
        }
    }
}