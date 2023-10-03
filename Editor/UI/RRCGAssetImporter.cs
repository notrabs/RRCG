using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace RRCG
{
    class RRCGScriptPreprocessor : AssetPostprocessor
    {
        public static bool AutoCompile = true;

        private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            if (!AutoCompile) return;

            //var pathToRRCG = GameObject.FindObjectsOfType<RRCG>().Where(rrcg => rrcg.RoomCircuit != null).ToDictionary(rrcg => AssetDatabase.GetAssetPath(rrcg.RoomCircuit), rrcg => rrcg);

            foreach (var importedAsset in importedAssets)
            {
                Debug.Log(importedAsset);
                 
                //if (pathToRRCG.TryGetValue(importedAsset, out RRCG rrcgMeta))
                //{
                //    try
                //    {
                //        RoslynFrontend.Compile(rrcgMeta);
                //    }
                //    catch (Exception ex)
                //    {
                //        Debug.LogException(ex);
                //    }
                //}
            }

            //if (!hasCompiled) EditorApplication.UnlockReloadAssemblies();
        }

        protected void OnPreprocessAsset()
        {
            if (!AutoCompile) return;

            Debug.Log(assetPath);
        }
    }
}
