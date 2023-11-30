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
            return CircuitBuilder.Singleton("ToString_" + Port.PortKey(), () => ChipBuilder.ToString(this));
        }
    }

    public class PortConversionUtils
    {
        public static int EncodeColor(Color color)
        {
            int r = (int)(color.r * 255);
            int g = (int)(color.g * 255);
            int b = (int)(color.b * 255);

            return (r << 16) + (g << 8) + b + 1000;
        }
    }

    public class PortBuilderAny : AnyPort { }
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
            if (IsActualPort) return CircuitBuilder.Singleton("List_IndexOf_" + Port.PortKey(), () => ChipBuilder.ListGetFirstIndexOf(this, value));
            return Data.IndexOf(value);
        }

        public T Min()
        {
            if (IsActualPort)
            {
                var minValue = this switch
                {
                    ListPort<FloatPort> floatList => CircuitBuilder.Singleton("List_Min_" + Port.PortKey(), () => ChipBuilder.ListMin(floatList)),
                    ListPort<IntPort> intList => CircuitBuilder.Singleton("List_Min_" + Port.PortKey(), () => ChipBuilder.ListMin(intList)),

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
                    ListPort<FloatPort> floatList => CircuitBuilder.Singleton("List_Max_" + Port.PortKey(), () => ChipBuilder.ListMax(floatList)),
                    ListPort<IntPort> intList => CircuitBuilder.Singleton("List_Max_" + Port.PortKey(), () => ChipBuilder.ListMax(intList)),

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

        public IntPort Count => CircuitBuilder.Singleton("List_Get_Count_" + Port.PortKey(), () => ChipBuilder.ListGetCount(this));
    }
    public class RRTuplePort<T0, T1> : AnyPort { }
    public class ColorPort : AnyPort
    {
        public ColorPort() { }
        public ColorPort(float r, float g, float b) { Data = PortConversionUtils.EncodeColor(new Color(r, g, b)); }
        public ColorPort(float r, float g, float b, float a) { Data = PortConversionUtils.EncodeColor(new Color(r, g, b, a)); }

        public static implicit operator ColorPort(Color data) => new ColorPort { Data = PortConversionUtils.EncodeColor(data) };
    }
    public class StringPort : AnyPort
    {
        public StringPort() { }
        public StringPort(char c, int count) { Data = new string(c, count); }

        public static implicit operator StringPort(string data) => new StringPort { Data = data };
        public static explicit operator string(StringPort data) => data.AsData<string>();

        public IntPort Length
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("String_Length_" + Port.PortKey(), () => ChipBuilder.StringLength(this));

                string str = (string)Data;
                return new IntPort { Data = str.Length };
            }
        }

        public StringPort ToUpper()
        {
            if (IsActualPort) return CircuitBuilder.Singleton("String_To_Upper_" + Port.PortKey(), () => ChipBuilder.StringToUpper(this));

            string str = (string)Data;
            return new StringPort { Data = str.ToUpper() };
        }

        public StringPort ToLower()
        {
            if (IsActualPort) return CircuitBuilder.Singleton("String_To_Lower_" + Port.PortKey(), () => ChipBuilder.StringToLower(this));

            string str = (string)Data;
            return new StringPort { Data = str.ToLower() };
        }
        public static StringPort operator +(StringPort a, StringPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new StringPort { Data = a.Data + b.Data };
            return ChipBuilder.Concat(a, b);
        }
    }
    public class IntPort : AnyPort
    {
        public static implicit operator IntPort(int data) => new IntPort { Data = data };
        public static explicit operator int(IntPort data) => data.AsData<int>();

        public static implicit operator FloatPort(IntPort data) => data.IsDataPort ? new FloatPort() { Data = (float)data.Data } : ChipBuilder.IntToFloat(data);

        public static explicit operator string(IntPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(IntPort data) => (string)data;

        public static IntPort operator -(IntPort data)
        {
            if (data.IsDataPort) return new IntPort { Data = -data.Data };
            return ChipBuilder.Subtract(0, data);
        }

        public static IntPort operator ++(IntPort a)
        {
            if (a.IsDataPort) return new IntPort { Data = a.Data + 1 };
            return ChipBuilder.Add(a, 1);
        }

        public static IntPort operator --(IntPort a)
        {
            if (a.IsDataPort) return new IntPort { Data = a.Data - 1 };
            return ChipBuilder.Add(a, -1);
        }

        public static IntPort operator +(IntPort a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new IntPort { Data = a.Data + b.Data };
            return ChipBuilder.Add(a, b);
        }

        public static IntPort operator -(IntPort a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new IntPort { Data = a.Data - b.Data };
            return ChipBuilder.Subtract(a, b);
        }

        public static IntPort operator *(IntPort a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new IntPort { Data = a.Data * b.Data };
            return ChipBuilder.Multiply(a, b);
        }
        public static IntPort operator /(IntPort a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new IntPort { Data = a.Data / b.Data };
            return ChipBuilder.Divide(a, b);
        }
        public static IntPort operator %(IntPort a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new IntPort { Data = a.Data % b.Data };
            return ChipBuilder.Modulo(a, b);
        }

        // These float variants are needed, because the automatic casting for [IntPort op float] will not look into the FloatPort class
        public static FloatPort operator +(IntPort a, float b) => a + (FloatPort)b;
        public static FloatPort operator -(IntPort a, float b) => a - (FloatPort)b;
        public static FloatPort operator *(IntPort a, float b) => a * (FloatPort)b;
        public static FloatPort operator /(IntPort a, float b) => a / (FloatPort)b;
        public static FloatPort operator %(IntPort a, float b) => a % (FloatPort)b;
        public static FloatPort operator +(float a, IntPort b) => (FloatPort)a + b;
        public static FloatPort operator -(float a, IntPort b) => (FloatPort)a - b;
        public static FloatPort operator *(float a, IntPort b) => (FloatPort)a * b;
        public static FloatPort operator /(float a, IntPort b) => (FloatPort)a / b;
        public static FloatPort operator %(float a, IntPort b) => (FloatPort)a % b;

        // These int variants are needed to disambiguate the float variants above
        public static IntPort operator +(IntPort a, int b) => a + (IntPort)b;
        public static IntPort operator -(IntPort a, int b) => a - (IntPort)b;
        public static IntPort operator *(IntPort a, int b) => a * (IntPort)b;
        public static IntPort operator /(IntPort a, int b) => a / (IntPort)b;
        public static IntPort operator %(IntPort a, int b) => a % (IntPort)b;
        public static IntPort operator +(int a, IntPort b) => (IntPort)a + b;
        public static IntPort operator -(int a, IntPort b) => (IntPort)a - b;
        public static IntPort operator *(int a, IntPort b) => (IntPort)a * b;
        public static IntPort operator /(int a, IntPort b) => (IntPort)a / b;
        public static IntPort operator %(int a, IntPort b) => (IntPort)a % b;

        public static IntPort operator &(IntPort a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new IntPort { Data = a.Data & b.Data };
            return ChipBuilder.BitAnd(a, b);
        }

        public static IntPort operator |(IntPort a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new IntPort { Data = a.Data | b.Data };
            return ChipBuilder.BitOr(a, b);
        }

        public static IntPort operator ^(IntPort a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new IntPort { Data = a.Data ^ b.Data };
            return ChipBuilder.BitXor(a, b);
        }

        public static IntPort operator ~(IntPort a)
        {
            if (a.IsDataPort) return new IntPort { Data = ~a.Data };
            return CircuitBuilder.Singleton("Bit_Not_" + a.Port.PortKey(), () => ChipBuilder.BitNot(a));
        }

        public static IntPort MaxValue => new IntPort { Data = int.MaxValue };
        public static IntPort MinValue => new IntPort { Data = int.MinValue };
    }
    public class FloatPort : AnyPort
    {
        public static implicit operator FloatPort(float data) => new FloatPort { Data = data };
        public static explicit operator float(FloatPort data) => data.AsData<float>();

        public static explicit operator IntPort(FloatPort data) => data.IsDataPort ? new IntPort() { Data = (int)data.Data } : ChipBuilder.FloorToInt(data);

        public static explicit operator string(FloatPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(FloatPort data) => (string)data;
        public static FloatPort operator -(FloatPort data)
        {
            if (data.IsDataPort) return new FloatPort { Data = -data.Data };
            return ChipBuilder.Subtract(0, data);
        }

        public static FloatPort operator ++(FloatPort a)
        {
            if (a.IsDataPort) return new FloatPort { Data = a.Data + 1 };
            return ChipBuilder.Add(a, 1);
        }
        public static FloatPort operator --(FloatPort a)
        {
            if (a.IsDataPort) return new FloatPort { Data = a.Data - 1 };
            return ChipBuilder.Add(a, -1);
        }
        public static FloatPort operator +(FloatPort a, FloatPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new FloatPort { Data = a.Data + b.Data };
            return ChipBuilder.Add(a, b);
        }
        public static FloatPort operator -(FloatPort a, FloatPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new FloatPort { Data = a.Data - b.Data };
            return ChipBuilder.Subtract(a, b);
        }
        public static FloatPort operator *(FloatPort a, FloatPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new FloatPort { Data = a.Data * b.Data };
            return ChipBuilder.Multiply(a, b);
        }
        public static FloatPort operator /(FloatPort a, FloatPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new FloatPort { Data = a.Data / b.Data };
            return ChipBuilder.Divide(a, b);
        }
        public static FloatPort operator %(FloatPort a, FloatPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new FloatPort { Data = a.Data % b.Data };
            return ChipBuilder.Modulo(a, b);
        }

        public static FloatPort PositiveInfinity => new FloatPort { Data = float.PositiveInfinity };
        public static FloatPort NegativeInfinity => new FloatPort { Data = float.NegativeInfinity };
        public static FloatPort MaxValue => new FloatPort { Data = float.MaxValue };
        public static FloatPort MinValue => new FloatPort { Data = float.MinValue };
    }
    public class BoolPort : AnyPort
    {
        public static implicit operator BoolPort(bool data) => new BoolPort { Data = data };
        public static explicit operator bool(BoolPort data) => data.AsData<bool>();

        public static explicit operator string(BoolPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(BoolPort data) => (string)data;
        public static BoolPort operator !(BoolPort data)
        {
            if (data.IsDataPort) return new BoolPort { Data = !data.Data };
            return ChipBuilder.Not(data);
        }
    }
    public class Vector3Port : AnyPort
    {
        public static Vector3Port zero { get => CircuitBuilder.Singleton("Vector3_zero", () => new Vector3Port()); }
        public static Vector3Port one { get => CircuitBuilder.Singleton("Vector3_one", () => new Vector3Port(1, 1, 1)); }
        public static Vector3Port up { get => CircuitBuilder.Singleton("Vector3_up", () => new Vector3Port(0, 1, 0)); }
        public static Vector3Port down { get => CircuitBuilder.Singleton("Vector3_down", () => new Vector3Port(0, -1, 0)); }
        public static Vector3Port forward { get => CircuitBuilder.Singleton("Vector3_forward", () => new Vector3Port(0, 0, 1)); }
        public static Vector3Port back { get => CircuitBuilder.Singleton("Vector3_back", () => new Vector3Port(0, 0, -1)); }
        public static Vector3Port right { get => CircuitBuilder.Singleton("Vector3_right", () => new Vector3Port(1, 0, 0)); }
        public static Vector3Port left { get => CircuitBuilder.Singleton("Vector3_left", () => new Vector3Port(-1, 0, 0)); }
        public static Vector3Port positiveInfinity { get => CircuitBuilder.Singleton("Vector3_positiveInfinity", () => new Vector3Port(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity)); }
        public static Vector3Port negativeInfinity { get => CircuitBuilder.Singleton("Vector3_negativeInfinity", () => new Vector3Port(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)); }

        public Vector3Port()
        {
            Data = new Vector3();
        }

        public Vector3Port(FloatPort x, FloatPort y, FloatPort z)
        {
            if (x.IsDataPort && y.IsDataPort && z.IsDataPort)
            {
                Data = new Vector3(x.AsData<float>(), y.AsData<float>(), z.AsData<float>());
            }
            else
            {
                Port = ChipBuilder.Vector3Create(x, y, z).Port;
            }
        }

        public (FloatPort X, FloatPort Y, FloatPort Z) split
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Vector3_split_" + Port.PortKey(), () => ChipBuilder.Vector3Split(this));

                var v = (Vector3)Data;
                return (v.x, v.y, v.z);
            }
        }

        public Vector3Port normalized
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Vector3_normalized_" + Port.PortKey(), () => ChipBuilder.Vector3Normalize(this));

                var v = (Vector3)Data;
                return new Vector3Port() { Data = v.normalized };
            }
        }
        public FloatPort magnitude
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Vector3_magnitude_" + Port.PortKey(), () => ChipBuilder.VectorGetMagnitude(this));

                var v = (Vector3)Data;
                return new FloatPort() { Data = v.magnitude };
            }
        }
        public FloatPort sqrMagnitude
        {
            get
            {
                // The RR philosophy: Calculate the efficient value by calculating the expensive value first...
                if (IsActualPort) return CircuitBuilder.Singleton("Vector3_sqrMagnitude_" + Port.PortKey(), () => this.magnitude * this.magnitude);

                var v = (Vector3)Data;
                return new FloatPort() { Data = v.sqrMagnitude };
            }
        }

        public FloatPort x { get => split.X; }
        public FloatPort y { get => split.Y; }
        public FloatPort z { get => split.Z; }

        public FloatPort this[IntPort index]
        {
            get
            {
                if (IsDataPort && index.IsDataPort) return new FloatPort() { Data = Data[index.Data] };
                if (index.IsDataPort) return index.Data switch
                {
                    0 => split.X,
                    1 => split.Y,
                    2 => split.Z,
                    _ => throw new Exception("Vector index out of bounds")
                };

                var (x, y, z) = split;
                return ChipLib.ValueSwitch(index, x, y, z);
            }
        }

        public static Vector3Port operator +(Vector3Port a, Vector3Port b)
        {
            if (a.IsDataPort && b.IsDataPort) return new Vector3Port { Data = a.Data + b.Data };
            return ChipBuilder.Add(a, b);
        }
        public static Vector3Port operator -(Vector3Port a, Vector3Port b)
        {
            if (a.IsDataPort && b.IsDataPort) return new Vector3Port { Data = a.Data - b.Data };
            return ChipBuilder.Subtract(a, b);
        }
        public static Vector3Port operator *(Vector3Port a, FloatPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new Vector3Port { Data = a.Data * b.Data };

            if (b.IsDataPort && (float)b.Data == -1f) // -1 is exactly representable
                return CircuitBuilder.Singleton("Vector3_Inverse_" + a.Port.PortKey(), () => ChipBuilder.Vector3Inverse(a));

            // This will fix the simple case for missing default value types. Leave it up to the user to force more complex types for now.
            if (b.IsDataPort) b = ChipLib.FloatConst(b);
            return ChipBuilder.Vector3Scale(a, b);
        }
        public static Vector3Port operator *(FloatPort a, Vector3Port b)
        {
            return b * a;
        }
        public static Vector3Port operator *(Vector3Port a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new Vector3Port { Data = a.Data * b.Data };

            if (b.IsDataPort && (int)b.Data == -1)
                return CircuitBuilder.Singleton("Vector3_Inverse_" + a.Port.PortKey(), () => ChipBuilder.Vector3Inverse(a));

            // This will fix the simple case for missing default value types. Leave it up to the user to force more complex types for now.
            if (b.IsDataPort) b = ChipLib.IntConst(b);
            return ChipBuilder.Vector3Scale(a, b);
        }
        public static Vector3Port operator *(IntPort a, Vector3Port b)
        {
            return b * a;
        }
        public static Vector3Port operator *(QuaternionPort a, Vector3Port b)
        {
            if (a.IsDataPort && b.IsDataPort) return new Vector3Port { Data = (Quaternion)a.Data * (Vector3)b.Data };
            return ChipBuilder.RotateVector(a, b);
        }

        public static Vector3Port operator /(Vector3Port a, FloatPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new Vector3Port { Data = a.Data / b.Data };
            // This will fix the simple case for missing default value types. Leave it up to the user to force more complex types for now.
            if (b.IsDataPort) b = ChipLib.FloatConst(b);
            return ChipBuilder.Vector3Scale(a, 1f / b);
        }
        public static Vector3Port operator /(Vector3Port a, IntPort b)
        {
            if (b.IsDataPort) return a / ChipLib.FloatConst(b);
            return a / (FloatPort)b;
        }
    }
    public class QuaternionPort : AnyPort
    {
        public static QuaternionPort identity { get => new QuaternionPort(0, 0, 0, 1); }

        public QuaternionPort()
        {
            Data = new Quaternion();
        }

        public QuaternionPort(FloatPort x, FloatPort y, FloatPort z, FloatPort w)
        {
            if (x.IsDataPort && y.IsDataPort && z.IsDataPort && w.IsDataPort)
            {
                Data = new Quaternion(x.AsData<float>(), y.AsData<float>(), z.AsData<float>(), w.AsData<float>());
            }
            else
            {
                Port = ChipBuilder.QuaternionCreate(x, y, z, w).Port;
            }
        }


        public Vector3Port eulerAngles
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Quaternion_eulerAngles_" + Port.PortKey(), () => ChipBuilder.QuaternionEulerAngles(this));

                var q = (Quaternion)Data;
                return new Vector3Port() { Data = q.eulerAngles };
            }
        }

        public QuaternionPort normalized
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Quaternion_normalized_" + Port.PortKey(), () => ChipBuilder.QuaternionNormalize(this));

                var q = (Quaternion)Data;
                return new QuaternionPort() { Data = q.normalized };
            }
        }

        public (FloatPort X, FloatPort Y, FloatPort Z, FloatPort W) split
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Quaternion_split_" + Port.PortKey(), () => ChipBuilder.QuaternionSplit(this));

                var q = (Quaternion)Data;
                return (q.x, q.y, q.z, q.w);
            }
        }

        public static QuaternionPort operator *(QuaternionPort a, QuaternionPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new QuaternionPort { Data = (Quaternion)a.Data * (Quaternion)b.Data };
            return ChipBuilder.Multiply(a, b);
        }
    }

    public class ObjectPort : AnyPort { }
    public class AIPort : AIPortGen { }
    public class WelcomeMatPort : WelcomeMatPortGen
    {
        public static implicit operator WelcomeMatPort(RecRoomObjectPort data) => new WelcomeMatPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TriggerHandlePort : TriggerHandlePortGen
    {
        public static implicit operator TriggerHandlePort(RecRoomObjectPort data) => new TriggerHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class StudioObjectPort : StudioObjectPortGen
    {
        public static implicit operator StudioObjectPort(RecRoomObjectPort data) => new StudioObjectPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class AnalyticsPayloadPort : AnalyticsPayloadPortGen { }
    public class PlayerPort : PlayerPortGen
    {
        public static PlayerPort Local = new PlayerPort() { Port = null, Data = 1 };
        public static PlayerPort Invalid = new PlayerPort() { Port = null, Data = 0 };
    }
    public class RecRoomObjectPort : RecRoomObjectPortGen
    {
        public static implicit operator RecRoomObjectPort(TriggerHandlePort data) => new RecRoomObjectPort() { Port = data.Port };
        public static implicit operator RecRoomObjectPort(StudioObjectPort data) => new RecRoomObjectPort() { Port = data.Port };
        public static implicit operator RecRoomObjectPort(SeatPort data) => new RecRoomObjectPort() { Port = data.Port };
        public static implicit operator RecRoomObjectPort(TextPort data) => new RecRoomObjectPort() { Port = data.Port };

        public static RecRoomObjectPort Invalid
        {
            get => CircuitBuilder.Singleton("RRCG_Invalid_RRO", () => new NamedVariable<RecRoomObjectPort>("RRCG_Invalid_RRO").Value);
        }
    }
    public class CombatantPort : CombatantPortGen { }
    public class PatrolPointPort : PatrolPointPortGen { }
    public class AudioPlayerPort : AudioPlayerPortGen
    {
        public static implicit operator AudioPlayerPort(RecRoomObjectPort data) => new AudioPlayerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ConsumablePort : ConsumablePortGen { }
    public class RoomKeyPort : RoomKeyPortGen { }
    public class BackgroundObjectsPort : BackgroundObjectsPortGen { }
    public class BeaconPort : BeaconPortGen
    {
        public static implicit operator BeaconPort(RecRoomObjectPort data) => new BeaconPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ButtonPort : ButtonPortGen
    {
        public static implicit operator ButtonPort(RecRoomObjectPort data) => new ButtonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TextScreenPort : TextScreenPortGen
    {
        public static implicit operator TextScreenPort(RecRoomObjectPort data) => new TextScreenPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class CollisionDataPort : CollisionDataPortGen
    {
        public FloatPort Distance => CircuitBuilder.Singleton("Collision_Data_Get_Distance_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetDistance(this));
        public Vector3Port Normal => CircuitBuilder.Singleton("Collision_Data_Get_Normal_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetNormal(this));
        public RecRoomObjectPort Object => CircuitBuilder.Singleton("Collision_Data_Get_Object_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetObject(this));
        public PlayerPort Player => CircuitBuilder.Singleton("Collision_Data_Get_Player_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetPlayer(this));
        public Vector3Port Position => CircuitBuilder.Singleton("Collision_Data_Get_Position_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetPosition(this));
    }
    public class CostumePort : CostumePortGen
    {
        public static implicit operator CostumePort(RecRoomObjectPort data) => new CostumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class DestinationRoomPort : DestinationRoomPortGen { }
    public class DiePort : DiePortGen
    {
        public static implicit operator DiePort(RecRoomObjectPort data) => new DiePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PlayerWorldUIPort : PlayerWorldUIPortGen { }
    public class RoomDoorPort : RoomDoorPortGen
    {
        public static implicit operator RoomDoorPort(RecRoomObjectPort data) => new RoomDoorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class EmitterPort : EmitterPortGen
    {
        public static implicit operator EmitterPort(RecRoomObjectPort data) => new EmitterPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ExplosionEmitterPort : ExplosionEmitterPortGen
    {
        public static implicit operator ExplosionEmitterPort(RecRoomObjectPort data) => new ExplosionEmitterPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class FogPort : FogPortGen { }
    public class HUDElementPort : HUDElementPortGen { }
    public class RewardPort : RewardPortGen { }
    public class GroundVehiclePort : GroundVehiclePortGen
    {
        public static implicit operator GroundVehiclePort(RecRoomObjectPort data) => new GroundVehiclePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class GunHandlePort : GunHandlePortGen
    {
        public static implicit operator GunHandlePort(RecRoomObjectPort data) => new GunHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class HolotarProjectorPort : HolotarProjectorPortGen
    {
        public static implicit operator HolotarProjectorPort(RecRoomObjectPort data) => new HolotarProjectorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InteractionVolumePort : InteractionVolumePortGen
    {
        public static implicit operator InteractionVolumePort(RecRoomObjectPort data) => new InteractionVolumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InvisibleCollisionPort : InvisibleCollisionPortGen
    {
        public static implicit operator InvisibleCollisionPort(RecRoomObjectPort data) => new InvisibleCollisionPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class LaserPointerPort : LaserPointerPortGen
    {
        public static implicit operator LaserPointerPort(RecRoomObjectPort data) => new LaserPointerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class LightPort : LightPortGen { }
    public class PistonPort : PistonPortGen
    {
        public static implicit operator PistonPort(RecRoomObjectPort data) => new PistonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PlayerOutfitSlotPort : PlayerOutfitSlotPortGen { }
    public class ProjectileLauncherPort : ProjectileLauncherPortGen
    {
        public static implicit operator ProjectileLauncherPort(RecRoomObjectPort data) => new ProjectileLauncherPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RemoteVideoPlayerPort : RemoteVideoPlayerPortGen
    {
        public static implicit operator RemoteVideoPlayerPort(RecRoomObjectPort data) => new RemoteVideoPlayerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PlayerSpawnPointV2Port : PlayerSpawnPointV2PortGen
    {
        public static implicit operator PlayerSpawnPointV2Port(RecRoomObjectPort data) => new PlayerSpawnPointV2Port() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SkydomePort : SkydomePortGen { }
    public class SunPort : SunPortGen { }
    public class SunDirectionPort : SunDirectionPortGen { }
    public class RotatorPort : RotatorPortGen
    {
        public static implicit operator RotatorPort(RecRoomObjectPort data) => new RotatorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SeatPort : SeatPortGen
    {
        public static implicit operator SeatPort(RecRoomObjectPort data) => new SeatPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SFXPort : SFXPortGen
    {
        public static implicit operator SFXPort(RecRoomObjectPort data) => new SFXPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TextPort : TextPortGen
    {
        public static implicit operator TextPort(RecRoomObjectPort data) => new TextPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ToggleButtonPort : ToggleButtonPortGen
    {
        public static implicit operator ToggleButtonPort(RecRoomObjectPort data) => new ToggleButtonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class MotionTrailPort : MotionTrailPortGen
    {
        public static implicit operator MotionTrailPort(RecRoomObjectPort data) => new MotionTrailPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TriggerVolumePort : TriggerVolumePortGen
    {
        public static implicit operator TriggerVolumePort(RecRoomObjectPort data) => new TriggerVolumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class VectorComponentPort : VectorComponentPortGen
    {
        public static implicit operator VectorComponentPort(RecRoomObjectPort data) => new VectorComponentPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RoomCurrencyPort : RoomCurrencyPortGen { }
    public class HUDConstantPort : HUDConstantPortGen
    {
        public static implicit operator HUDConstantPort(RecRoomObjectPort data) => new HUDConstantPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SteeringEnginePort : SteeringEnginePortGen
    {
        public static implicit operator SteeringEnginePort(RecRoomObjectPort data) => new SteeringEnginePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class GiftDropShopItemPort : GiftDropShopItemPortGen
    {
        public static implicit operator GiftDropShopItemPort(RecRoomObjectPort data) => new GiftDropShopItemPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ObjectiveMarkerPort : ObjectiveMarkerPortGen
    {
        public static implicit operator ObjectiveMarkerPort(RecRoomObjectPort data) => new ObjectiveMarkerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class MeleeZonePort : MeleeZonePortGen
    {
        public static implicit operator MeleeZonePort(RecRoomObjectPort data) => new MeleeZonePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SwingHandlePort : SwingHandlePortGen
    {
        public static implicit operator SwingHandlePort(RecRoomObjectPort data) => new SwingHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RoomLevelHUDPort : RoomLevelHUDPortGen
    {
        public static implicit operator RoomLevelHUDPort(RecRoomObjectPort data) => new RoomLevelHUDPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TouchpadPort : TouchpadPortGen
    {
        public static implicit operator TouchpadPort(RecRoomObjectPort data) => new TouchpadPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class AnimationControllerPort : AnimationControllerPortGen
    {
        public static implicit operator AnimationControllerPort(RecRoomObjectPort data) => new AnimationControllerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InventoryItemPort : InventoryItemPortGen { }
    public class StatePort : StatePortGen { }
    public class GrabberPort : GrabberPortGen { }
    public class EquipmentSlotPort : EquipmentSlotPortGen { }
    public class DialogueUIPort : DialogueUIPortGen { }
    public class CollisionDetectionVolumePort : CollisionDetectionVolumePortGen { }
    public class RoomOfferPort : RoomOfferPortGen { }
}
