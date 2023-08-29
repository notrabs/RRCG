using UnityEngine;
using UnityEditor;

namespace RRCG
{
    public class RRCGEditor : MonoBehaviour
    {
        [CustomEditor(typeof(RRCG))]
        public class RRCGInpsector : Editor
        {
            public override void OnInspectorGUI()
            {
                DrawDefaultInspector();

                RRCG rrcgMeta = (RRCG)target;

                if (GUILayout.Button("Compile Circuits"))
                {
                    RoslynFrontend.Compile(rrcgMeta);
                }

                if (GUILayout.Button("Build Circuits"))
                {
                    Application.OpenURL("https://recroom.featureupvote.com/suggestions/482338/circuits-api");
                    EditorUtility.DisplayDialog("WIP", "Please upvote this feature request :]\nTo bring the generated graphs into the game we need official support for programmatic circuit manipulation.", "Ok");
                }

                if (GUILayout.Button("Copy Debug Graph"))
                {
                    var context = RoslynFrontend.GetBuilt(rrcgMeta);
                    DotGraphBackend.Build(context);
                }
            }
        }
    }
}