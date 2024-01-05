using RRCG.Optimizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace RRCG
{
    [CustomEditor(typeof(RRCGStudioObject))]
    public class RRCGStudioObjectInpsector : Editor
    {
        DescriptorSelector descriptorSelector = new DescriptorSelector(
            "Studio Object Descriptor", 
            Utils.GetAllAvailableStudioObjectDescriptors,
            Utils.GetAllAvailableStudioObjectDescriptorsInProject
        );

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            RRCGStudioObject rrcgMeta = (RRCGStudioObject)target;

            if (descriptorSelector.Draw(rrcgMeta)) return;

            if (GUILayout.Button("Update Events/Functions", GUILayout.Height(50)))
            {
                _ = RoslynFrontend.UpdateRRO(rrcgMeta);
            }
        }
    }
}
