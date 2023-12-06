using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace RRCG
{
    public class RRCGScriptPreprocessor : AssetPostprocessor
    {
        public static bool AutoCompile
        {
            get => EditorPrefs.GetBool("RRCG_USE_SCRIPT_POSTPROCESSOR", true);
            set => EditorPrefs.SetBool("RRCG_USE_SCRIPT_POSTPROCESSOR", value);
        }

        protected void OnPreprocessAsset()
        {
            if (!AutoCompile) return;

            if (assetPath.EndsWith(".rrcg.cs"))
            {
                Debug.Log("RRCG Compiling: " + Path.GetFileName(assetPath));

                var targetFile = assetPath.Replace(".rrcg.cs", ".rrcg.gen.cs");

                RoslynFrontend.CompileFile(assetPath, targetFile);
            }
        }
    }
}
