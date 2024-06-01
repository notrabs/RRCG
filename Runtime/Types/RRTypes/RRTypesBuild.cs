using RRCG;
using RRCGGenerated;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UnityEngine;

namespace RRCGBuild
{
    public class AnyPort
    {
        public Port Port;
        public dynamic Data;

        public bool IsDataPort => Port == null;
        public bool IsActualPort => Port != null;

        public static implicit operator AnyPort(string data) => new StringPort { Data = data };
        public static implicit operator AnyPort(int data) => new IntPort { Data = data };
        public static implicit operator AnyPort(float data) => new FloatPort { Data = data };
        public static implicit operator AnyPort(bool data) => new BoolPort { Data = data };
        public static implicit operator AnyPort(Color data) => new ColorPort { Data = PortConversionUtils.EncodeColor(data) };
        public static implicit operator AnyPort(Vector3 data) => new Vector3Port { Data = data };
        public static implicit operator AnyPort(Quaternion data) => new QuaternionPort { Data = data };

        public static StringPort operator +(StringPort a, AnyPort b) => a + b.ToString();
        public static StringPort operator +(AnyPort a, StringPort b) => a.ToString() + b;

        /// <summary>
        /// Converts complex data value ports into actual ports that can be connected to
        /// </summary>
        public AnyPort AsConnectable()
        {
            if (IsDataPort)
            {
                // This solution is problematic because without the IsProperNode hack it overrides the lastSpawnedNode in the spawning functions.
                if (Data is Vector3 vec3) return CircuitBuilder.Singleton("Vector3_" + vec3.x + "_" + vec3.y + "_" + vec3.z, () =>
                {
                    var port = ChipBuilder.Vector3Create(vec3.x, vec3.y, vec3.z);
                    Context.lastSpawnedNode.IsProperNode = false;
                    return port;
                }
                );
                if (Data is Quaternion quat) return CircuitBuilder.Singleton("Quaternion_" + quat.x + "_" + quat.y + "_" + quat.z + "_" + quat.w, () =>
                {
                    var port = ChipBuilder.QuaternionCreate(quat.x, quat.y, quat.z, quat.w);
                    Context.lastSpawnedNode.IsProperNode = false;
                    return port;
                });
            }
            return this;
        }

        /// <summary>
        /// Casts the data in the Port into any type. Only use when you are sure the data is correct, as actual ports will crash.
        /// </summary>
        public T AsData<T>()
        {
            if (IsActualPort) throw new Exception("Cannot convert actual port to data");
            return (T)Data;
        }

        /// <summary>
        /// Use this method ONLY in RRCG source code to trick the compiler into accepting your port.
        /// </summary>
        public T AsSourcePort<T>() => this as dynamic;

        public BoolPort IsValid
        {
            get
            {
                if (IsDataPort) return false;
                else return CircuitBuilder.Singleton("IsValid_" + PortKey(), () => ChipBuilder.IsValid(this));
            }
        }

        public new StringPort ToString()
        {
            if (IsDataPort)
            {
                // Type-specific overrides to match CV2's string representation
                if (this is FloatPort)
                    return ((float)Data).ToString(CultureInfo.InvariantCulture);

                if (this is IntPort)
                    return ((int)Data).ToString(CultureInfo.InvariantCulture);

                if (this is ColorPort)
                    return $"#{((int)Data) - 1000:X6}";

                return Data.ToString();
            }

            if (this is StringPort sp) return sp;
            return CircuitBuilder.Singleton("ToString_" + PortKey(), () => ChipBuilder.ToString(this));
        }

        public string PortKey()
        {
            if (IsActualPort) return Port.Node.Id + "_" + Port.Group + "_" + Port.Index;
            return "Data_" + Data.GetType() + "_" + Data.ToString();
        }

        public bool EquivalentTo(AnyPort b)
        {
            // Actual port status must match
            if (IsActualPort != b.IsActualPort) return false;

            // Port source must match
            if (IsActualPort)
                return Port.EquivalentTo(b.Port);

            // Data must match
            return Data == b.Data;
        }
    }

    public class ListPort<T> : AnyPort where T : AnyPort, new()
    {
        public T this[IntPort i]
        {
            get
            {
                return ChipBuilder.ListGetElement(this, i);
            }
            set
            {
                ChipBuilder.ListSetElement<T>(this, i, value);
            }
        }

        public IntPort IndexOf(T value)
        {
            if (IsActualPort) return CircuitBuilder.Singleton($"List_IndexOf_{PortKey()}_value_{value.PortKey()}", () => ChipBuilder.ListGetFirstIndexOf(this, value));
            return Data.IndexOf(value);
        }

        public BoolPort Contains(T value)
        {
            if (IsActualPort) return CircuitBuilder.Singleton($"List_Contains_{PortKey()}_value_{value.PortKey()}", () => ChipBuilder.ListContains(this, value));
            return Data.Contains(value);
        }

        public void Add(T value)
        {
            if (IsActualPort) ChipBuilder.ListAdd(this, value);
            else Data.Add(value);
        }

        public void Clear()
        {
            if (IsActualPort) ChipBuilder.ListClear(this);
            else Data.Clear();
        }

        public T Min()
        {
            if (IsActualPort)
            {
                var minValue = this switch
                {
                    ListPort<FloatPort> floatList => CircuitBuilder.Singleton("List_Min_" + PortKey(), () => ChipBuilder.ListMin(floatList)),
                    ListPort<IntPort> intList => CircuitBuilder.Singleton("List_Min_" + PortKey(), () => ChipBuilder.ListMin(intList)),

                    _ => throw new Exception("Min() is only supported on number ports")
                };
                return minValue as T;
            }
            else
            {
                var minValue = Data switch
                {
                    List<float> floatList => floatList.Min(),
                    List<int> intList => intList.Min(),

                    _ => throw new Exception("Min() is only supported on number ports")
                };
                return minValue as T;
            }
        }

        public T Max()
        {
            if (IsActualPort)
            {
                var maxValue = this switch
                {
                    ListPort<FloatPort> floatList => CircuitBuilder.Singleton("List_Max_" + PortKey(), () => ChipBuilder.ListMax(floatList)),
                    ListPort<IntPort> intList => CircuitBuilder.Singleton("List_Max_" + PortKey(), () => ChipBuilder.ListMax(intList)),

                    _ => throw new Exception("Max() is only supported on number ports")
                };
                return maxValue as T;
            }
            else
            {
                var maxValue = Data switch
                {
                    List<float> floatList => floatList.Max(),
                    List<int> intList => intList.Max(),

                    _ => throw new Exception("Max() is only supported on number ports")
                };
                return maxValue as T;
            }
        }

        public IntPort Count => CircuitBuilder.Singleton("List_Get_Count_" + PortKey(), () => ChipBuilder.ListGetCount(this));
    }
    public class RRTuplePort<T0, T1> : AnyPort { }

    //
    // Misc Types
    //

    public class AIPort : AIPortGen { }
    public class AnalyticsPayloadPort : AnalyticsPayloadPortGen { }
    public class PlayerPort : PlayerPortGen
    {
        public static PlayerPort Local = new PlayerPort() { Port = null, Data = 1 };
        public static PlayerPort Invalid = new PlayerPort() { Port = null, Data = 0 };
    }

    public class CombatantPort : CombatantPortGen { }
    public class PatrolPointPort : PatrolPointPortGen { }
    public class ConsumablePort : ConsumablePortGen { }
    public class RoomKeyPort : RoomKeyPortGen { }
    public class BackgroundObjectsPort : BackgroundObjectsPortGen { }
    public class CollisionDataPort : CollisionDataPortGen { }
    public class DestinationRoomPort : DestinationRoomPortGen { }
    public class PlayerWorldUIPort : PlayerWorldUIPortGen { }
    public class FogPort : FogPortGen { }
    public class HUDElementPort : HUDElementPortGen { }
    public class RewardPort : RewardPortGen { }
    public class PlayerOutfitSlotPort : PlayerOutfitSlotPortGen { }
    public class SkydomePort : SkydomePortGen { }
    public class SunPort : SunPortGen { }
    public class SunDirectionPort : SunDirectionPortGen { }
    public class RoomCurrencyPort : RoomCurrencyPortGen { }
    public class InventoryItemPort : InventoryItemPortGen { }
    public class StatePort : StatePortGen { }
    public class EquipmentSlotPort : EquipmentSlotPortGen { }
    public class DialogueUIPort : DialogueUIPortGen { }
    public class CollisionDetectionVolumePort : CollisionDetectionVolumePortGen { }
    public class RoomOfferPort : RoomOfferPortGen { }
    public class RecNetImagePort : RecNetImagePortGen { }
    public class RangedWeaponPort : RangedWeaponPortGen { }
    public class StorefrontPort : StorefrontPortGen { }
}
