using UnityEngine;
using UnityEngine.Serialization;

namespace RRCG
{
    public abstract class RRCG : MonoBehaviour
    {
        [HideInInspector]
        [FormerlySerializedAs("RoomCircuitAssembly")]
        public string Assembly;

        [HideInInspector]
        [FormerlySerializedAs("RoomCircuitClass")]
        public string DescriptorClass;
    }
}
