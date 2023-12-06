using UnityEngine;
using UnityEngine.Serialization;

namespace RRCG
{
    public abstract class RRCG : MonoBehaviour
    {

        //
        // RoslynFrontend metadata describing where to find a compiled RRCG class.
        //

        [HideInInspector]
        // The RRCG project name (empty if the class is compiled in Unity)
        public string Project;

        [HideInInspector]
        // The Assembly name (empty if using a standalone project)
        public string Assembly;

        [HideInInspector]
        // The class to load from the project/assembly
        public string DescriptorClass;
    }
}
