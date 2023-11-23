
using RRCG;
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
    public class LightPort : AnyPort { }
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
            // This will fix the simple case for missing default value types. Leave it up to the user to force more complex types for now.
            if (b.IsDataPort) b = ChipLib.IntConst(b);
            return ChipBuilder.Vector3Scale(a, b);
        }
        public static Vector3Port operator *(IntPort a, Vector3Port b)
        {
            return b * a;
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
    }

    public class ObjectPort : AnyPort { }
    public class AIPort : AnyPort { }
    public class WelcomeMatPort : AnyPort
    {
        public static implicit operator WelcomeMatPort(RecRoomObjectPort data) => new WelcomeMatPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TriggerHandlePort : AnyPort
    {
        public static implicit operator TriggerHandlePort(RecRoomObjectPort data) => new TriggerHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class StudioObjectPort : AnyPort
    {
        public static implicit operator StudioObjectPort(RecRoomObjectPort data) => new StudioObjectPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class AnalyticsPayloadPort : AnyPort { }
    public class PlayerPort : AnyPort
    {
        public static PlayerPort Local = new PlayerPort() { Port = null, Data = 1 };
        public static PlayerPort Invalid = new PlayerPort() { Port = null, Data = 0 };
    }
    public class RecRoomObjectPort : AnyPort
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
    public class CombatantPort : AnyPort { }
    public class PatrolPointPort : AnyPort { }
    public class AudioPort : AnyPort
    {
        public SFXConstantData SFXData;

        public static AudioPort AudioSFXConstant(string clipName)
        {
            return ChipBuilder.SFXConstant(new SFXConstantData(clipName));
        }

        public static AudioPort SFX_Click { get => CircuitBuilder.Singleton("SFX_Click", () => AudioSFXConstant("Click")); }
        public static AudioPort SFX_Firework { get => CircuitBuilder.Singleton("SFX_Firework", () => AudioSFXConstant("Firework")); }
        public static AudioPort SFX_UIXP02 { get => CircuitBuilder.Singleton("SFX_UIXP02", () => AudioSFXConstant("UIXP02")); }
        public static AudioPort SFX_CrowdAww { get => CircuitBuilder.Singleton("SFX_CrowdAww", () => AudioSFXConstant("CrowdAww")); }
        public static AudioPort SFX_CrowdCheer { get => CircuitBuilder.Singleton("SFX_CrowdCheer", () => AudioSFXConstant("CrowdCheer")); }
        public static AudioPort SFX_TriggerMisfire { get => CircuitBuilder.Singleton("SFX_TriggerMisfire", () => AudioSFXConstant("TriggerMisfire")); }
        public static AudioPort SFX_UIScore01 { get => CircuitBuilder.Singleton("SFX_UIScore01", () => AudioSFXConstant("UIScore01")); }
        public static AudioPort SFX_UIScore04 { get => CircuitBuilder.Singleton("SFX_UIScore04", () => AudioSFXConstant("UIScore04")); }
    }
    public class AudioPlayerPort : AnyPort
    {
        public static implicit operator AudioPlayerPort(RecRoomObjectPort data) => new AudioPlayerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ConsumablePort : AnyPort { }
    public class RoomKeyPort : AnyPort { }
    public class BackgroundObjectsPort : AnyPort { }
    public class BeaconPort : AnyPort
    {
        public static implicit operator BeaconPort(RecRoomObjectPort data) => new BeaconPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ButtonPort : AnyPort
    {
        public static implicit operator ButtonPort(RecRoomObjectPort data) => new ButtonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TextScreenPort : AnyPort
    {
        public static implicit operator TextScreenPort(RecRoomObjectPort data) => new TextScreenPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class CollisionDataPort : AnyPort { }
    public class CostumePort : AnyPort
    {
        public static implicit operator CostumePort(RecRoomObjectPort data) => new CostumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class DestinationRoomPort : AnyPort { }
    public class DiePort : AnyPort
    {
        public static implicit operator DiePort(RecRoomObjectPort data) => new DiePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PlayerWorldUIPort : AnyPort { }
    public class RoomDoorPort : AnyPort
    {
        public static implicit operator RoomDoorPort(RecRoomObjectPort data) => new RoomDoorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class EmitterPort : AnyPort
    {
        public static implicit operator EmitterPort(RecRoomObjectPort data) => new EmitterPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ExplosionEmitterPort : AnyPort
    {
        public static implicit operator ExplosionEmitterPort(RecRoomObjectPort data) => new ExplosionEmitterPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class FogPort : AnyPort { }
    public class HUDElementPort : AnyPort { }
    public class RewardPort : AnyPort { }
    public class GroundVehiclePort : AnyPort
    {
        public static implicit operator GroundVehiclePort(RecRoomObjectPort data) => new GroundVehiclePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class GunHandlePort : AnyPort
    {
        public static implicit operator GunHandlePort(RecRoomObjectPort data) => new GunHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class HolotarProjectorPort : AnyPort
    {
        public static implicit operator HolotarProjectorPort(RecRoomObjectPort data) => new HolotarProjectorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InteractionVolumePort : AnyPort
    {
        public static implicit operator InteractionVolumePort(RecRoomObjectPort data) => new InteractionVolumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InvisibleCollisionPort : AnyPort
    {
        public static implicit operator InvisibleCollisionPort(RecRoomObjectPort data) => new InvisibleCollisionPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class LaserPointerPort : AnyPort
    {
        public static implicit operator LaserPointerPort(RecRoomObjectPort data) => new LaserPointerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PistonPort : AnyPort
    {
        public static implicit operator PistonPort(RecRoomObjectPort data) => new PistonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PlayerOutfitSlotPort : AnyPort { }
    public class ProjectileLauncherPort : AnyPort
    {
        public static implicit operator ProjectileLauncherPort(RecRoomObjectPort data) => new ProjectileLauncherPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RemoteVideoPlayerPort : AnyPort
    {
        public static implicit operator RemoteVideoPlayerPort(RecRoomObjectPort data) => new RemoteVideoPlayerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PlayerSpawnPointV2Port : AnyPort
    {
        public static implicit operator PlayerSpawnPointV2Port(RecRoomObjectPort data) => new PlayerSpawnPointV2Port() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SkydomePort : AnyPort { }
    public class SunPort : AnyPort { }
    public class SunDirectionPort : AnyPort { }
    public class RotatorPort : AnyPort
    {
        public static implicit operator RotatorPort(RecRoomObjectPort data) => new RotatorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SeatPort : AnyPort
    {
        public static implicit operator SeatPort(RecRoomObjectPort data) => new SeatPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SFXPort : AnyPort
    {
        public static implicit operator SFXPort(RecRoomObjectPort data) => new SFXPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TextPort : AnyPort
    {
        public static implicit operator TextPort(RecRoomObjectPort data) => new TextPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ToggleButtonPort : AnyPort
    {
        public static implicit operator ToggleButtonPort(RecRoomObjectPort data) => new ToggleButtonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class MotionTrailPort : AnyPort
    {
        public static implicit operator MotionTrailPort(RecRoomObjectPort data) => new MotionTrailPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TriggerVolumePort : AnyPort
    {
        public static implicit operator TriggerVolumePort(RecRoomObjectPort data) => new TriggerVolumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class VectorComponentPort : AnyPort
    {
        public static implicit operator VectorComponentPort(RecRoomObjectPort data) => new VectorComponentPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RoomCurrencyPort : AnyPort { }
    public class HUDConstantPort : AnyPort
    {
        public static implicit operator HUDConstantPort(RecRoomObjectPort data) => new HUDConstantPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SteeringEnginePort : AnyPort
    {
        public static implicit operator SteeringEnginePort(RecRoomObjectPort data) => new SteeringEnginePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class GiftDropShopItemPort : AnyPort
    {
        public static implicit operator GiftDropShopItemPort(RecRoomObjectPort data) => new GiftDropShopItemPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ObjectiveMarkerPort : AnyPort
    {
        public static implicit operator ObjectiveMarkerPort(RecRoomObjectPort data) => new ObjectiveMarkerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class MeleeZonePort : AnyPort
    {
        public static implicit operator MeleeZonePort(RecRoomObjectPort data) => new MeleeZonePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SwingHandlePort : AnyPort
    {
        public static implicit operator SwingHandlePort(RecRoomObjectPort data) => new SwingHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RoomLevelHUDPort : AnyPort
    {
        public static implicit operator RoomLevelHUDPort(RecRoomObjectPort data) => new RoomLevelHUDPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TouchpadPort : AnyPort
    {
        public static implicit operator TouchpadPort(RecRoomObjectPort data) => new TouchpadPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class AnimationControllerPort : AnyPort
    {
        public static implicit operator AnimationControllerPort(RecRoomObjectPort data) => new AnimationControllerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InventoryItemPort : AnyPort { }
    public class StatePort : AnyPort { }
    public class GrabberPort : AnyPort { }
    public class EquipmentSlotPort : AnyPort { }
    public class DialogueUIPort : AnyPort { }
    public class CollisionDetectionVolumePort : AnyPort { }
}
