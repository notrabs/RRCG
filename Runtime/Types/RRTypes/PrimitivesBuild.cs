
using System;

namespace RRCGBuild
{
    public class BoolPort : AnyPort
    {
        public static implicit operator BoolPort(bool data) => new BoolPort { Data = data };
        public static explicit operator bool(BoolPort data) => data.AsData<bool>();

        public static explicit operator string(BoolPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(BoolPort data) => data.ToString();
        public static BoolPort operator !(BoolPort data)
        {
            if (data.IsDataPort) return new BoolPort { Data = !data.Data };
            return ChipBuilder.Not(data);
        }
    }

    public class IntPort : AnyPort
    {
        public static implicit operator IntPort(int data) => new IntPort { Data = data };
        public static explicit operator int(IntPort data) => data.AsData<int>();

        public static implicit operator FloatPort(IntPort data) => data.IsDataPort ? new FloatPort() { Data = (float)data.Data } : ChipBuilder.IntToFloat(data);

        public static explicit operator string(IntPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(IntPort data) => data.ToString();

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
            return ChipBuilder.Remainder(a, b);
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
            return CircuitBuilder.Singleton("Bit_Not_" + a.PortKey(), () => ChipBuilder.BitNot(a));
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
        public static explicit operator StringPort(FloatPort data) => data.ToString();
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
            return ChipBuilder.Remainder(a, b);
        }

        public static FloatPort PositiveInfinity => new FloatPort { Data = float.PositiveInfinity };
        public static FloatPort NegativeInfinity => new FloatPort { Data = float.NegativeInfinity };
        public static FloatPort MaxValue => new FloatPort { Data = float.MaxValue };
        public static FloatPort MinValue => new FloatPort { Data = float.MinValue };
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
                if (IsActualPort) return CircuitBuilder.Singleton("String_Length_" + PortKey(), () => ChipBuilder.StringLength(this));

                string str = (string)Data;
                return new IntPort { Data = str.Length };
            }
        }

        public StringPort Substring(IntPort Index, IntPort Length = null)
        {
            if (IsActualPort || Index.IsActualPort || Length.IsActualPort) return ChipBuilder.StringSubstring(this, Index, Length ?? int.MaxValue);

            string str = (string)Data;
            return new StringPort { Data = str.Substring(Index.Data, Length?.Data ?? int.MaxValue) };
        }
        public ListPort<StringPort> Split(StringPort Divider)
        {
            if (IsDataPort && Divider.IsDataPort) return new ListPort<StringPort>() { Data = Data.Split(Divider.AsData<string>()) };
            return ChipBuilder.StringSplit(this, Divider);
        }

        public StringPort ToUpper()
        {
            if (IsActualPort) return CircuitBuilder.Singleton("String_To_Upper_" + PortKey(), () => ChipBuilder.StringToUpper(this));

            string str = (string)Data;
            return new StringPort { Data = str.ToUpper() };
        }

        public StringPort ToLower()
        {
            if (IsActualPort) return CircuitBuilder.Singleton("String_To_Lower_" + PortKey(), () => ChipBuilder.StringToLower(this));

            string str = (string)Data;
            return new StringPort { Data = str.ToLower() };
        }

        public StringPort Trim()
        {
            if (IsActualPort) return CircuitBuilder.Singleton("String_Trim_" + PortKey(), () => ChipBuilder.StringTrim(this));

            string str = (string)Data;
            return new StringPort { Data = str.Trim() };
        }

        public static StringPort operator +(StringPort a, StringPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new StringPort { Data = a.Data + b.Data };
            return ChipBuilder.Concat(a, b);
        }

        public IntPort IndexOf(StringPort substring)
        {
            if (IsDataPort && substring.IsDataPort) return new IntPort { Data = Data.IndexOf(substring.Data) };
            return CircuitBuilder.Singleton($"String_Index_Of_{PortKey()}_substring_{substring.PortKey()}", () => ChipBuilder.StringIndexOf(this, substring));
        }
    }

    // This crashes Unity for some reason...
    //public static class StringExtensions
    //{
    //    // This is needed to make "".Split(stringPort) work on literals
    //    public static ListPort<StringPort> Split(this string input, StringPort chr)
    //    {
    //        return input.Split(chr);
    //    }
    //}
}
