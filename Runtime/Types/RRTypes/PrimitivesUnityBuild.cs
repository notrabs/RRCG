using RRCG;
using System;
using UnityEngine;

namespace RRCGBuild
{
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
                if (IsActualPort) return CircuitBuilder.Singleton("Vector3_split_" + PortKey(), () => ChipBuilder.Vector3Split(this));

                var v = (Vector3)Data;
                return (v.x, v.y, v.z);
            }
        }

        public Vector3Port normalized
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Vector3_normalized_" + PortKey(), () => ChipBuilder.Vector3Normalize(this));

                var v = (Vector3)Data;
                return new Vector3Port() { Data = v.normalized };
            }
        }
        public FloatPort magnitude
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Vector3_magnitude_" + PortKey(), () => ChipBuilder.VectorGetMagnitude(this));

                var v = (Vector3)Data;
                return new FloatPort() { Data = v.magnitude };
            }
        }
        public FloatPort sqrMagnitude
        {
            get
            {
                // The RR philosophy: Calculate the efficient value by calculating the expensive value first...
                if (IsActualPort) return CircuitBuilder.Singleton("Vector3_sqrMagnitude_" + PortKey(), () => this.magnitude * this.magnitude);

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
        public static Vector3Port operator -(Vector3Port v)
        {
            if (v.IsDataPort) return new Vector3Port { Data = -v.Data };
            return ChipBuilder.Vector3Inverse(v);
        }
        public static Vector3Port operator *(Vector3Port a, FloatPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new Vector3Port { Data = a.Data * b.Data };

            if (b.IsDataPort && (float)b.Data == -1f) // -1 is exactly representable
                return CircuitBuilder.Singleton("Vector3_Inverse_" + a.PortKey(), () => ChipBuilder.Vector3Inverse(a));

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
                return CircuitBuilder.Singleton("Vector3_Inverse_" + a.PortKey(), () => ChipBuilder.Vector3Inverse(a));

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

        public static implicit operator Vector3Port(Vector3 data) => new Vector3Port { Data = data };
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

        public FloatPort x { get => split.X; }
        public FloatPort y { get => split.Y; }
        public FloatPort z { get => split.Z; }
        public FloatPort w { get => split.W; }

        public Vector3Port eulerAngles
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Quaternion_eulerAngles_" + PortKey(), () => ChipBuilder.QuaternionEulerAngles(this));

                var q = (Quaternion)Data;
                return new Vector3Port() { Data = q.eulerAngles };
            }
        }

        public QuaternionPort normalized
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Quaternion_normalized_" + PortKey(), () => ChipBuilder.QuaternionNormalize(this));

                var q = (Quaternion)Data;
                return new QuaternionPort() { Data = q.normalized };
            }
        }

        public (FloatPort X, FloatPort Y, FloatPort Z, FloatPort W) split
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Quaternion_split_" + PortKey(), () => ChipBuilder.QuaternionSplit(this));

                var q = (Quaternion)Data;
                return (q.x, q.y, q.z, q.w);
            }
        }

        public static QuaternionPort Euler(FloatPort X, FloatPort Y, FloatPort Z)
        {
            if (X.IsDataPort && Y.IsDataPort && Z.IsDataPort) return (QuaternionPort)Quaternion.Euler(X.Data, Y.Data, Z.Data);
            return ChipBuilder.QuaternionCreateEulerAngles(new Vector3Port(X, Y, Z));
        }

        public static QuaternionPort operator *(QuaternionPort a, QuaternionPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new QuaternionPort { Data = (Quaternion)a.Data * (Quaternion)b.Data };
            return ChipBuilder.Multiply(a, b);
        }

        public static implicit operator QuaternionPort(Quaternion data) => new QuaternionPort { Data = data };
    }

    public class ColorPort : AnyPort
    {
        public ColorPort() { }
        public ColorPort(FloatPort r, FloatPort g, FloatPort b)
        {
            if (r.IsDataPort && g.IsDataPort && b.IsDataPort) Data = PortConversionUtils.EncodeColor(new Color(r.Data, g.Data, b.Data));
            else Port = ChipBuilder.RGBToColor(r, g, b).Port;
        }

        // There is no alpha in the in-game color type. This constructure should probably not be used.
        public ColorPort(float r, float g, float b, float a) { Data = PortConversionUtils.EncodeColor(new Color(r, g, b, a)); }

        public static ColorPort black => Color.black;
        public static ColorPort cyan => Color.cyan;
        public static ColorPort gray => Color.gray;
        public static ColorPort green => Color.green;
        public static ColorPort grey => Color.grey;
        public static ColorPort magenta => Color.magenta;
        public static ColorPort red => Color.red;
        public static ColorPort white => Color.white;
        public static ColorPort yellow => Color.yellow;

        public FloatPort grayscale
        {
            get
            {
                if (IsDataPort) return (FloatPort)PortConversionUtils.DecodeColor(Data).grayscale;
                
                var (r, g, b) = ChipBuilder.ColorToRGB(this);
                return 0.299f * r + 0.587f * g + 0.114f * b;
            }
        }

        public static ColorPort HSVToRGB(FloatPort h, FloatPort s, FloatPort v)
        {
            if (h.IsDataPort && s.IsDataPort && v.IsDataPort) return (ColorPort)Color.HSVToRGB(h.Data, s.Data, v.Data);
            return ChipBuilder.HSVToColor(h, s, v);
        }

        public static implicit operator ColorPort(Color data) => new ColorPort { Data = PortConversionUtils.EncodeColor(data) };
    }
}
