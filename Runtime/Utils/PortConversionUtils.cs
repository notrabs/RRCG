using RRCGBuild;
using System;
using System.Linq;
using UnityEngine;

namespace RRCG
{
    internal class PortConversionUtils
    {
        public static int EncodeColor(Color color)
        {
            int r = (int)(color.r * 255);
            int g = (int)(color.g * 255);
            int b = (int)(color.b * 255);

            return (r << 16) + (g << 8) + b + 1000;
        }

        public static Color DecodeColor(int colorInt)
        {
            colorInt -= 1000;

            int r = (colorInt >> 16) & 0xFF;
            int g = (colorInt >> 8) & 0xFF;
            int b = colorInt & 0xFF;

            return new Color(r / 255f, g / 255f, b / 255f);
        }

        public static AnyPort ToAnyPort(object value)
        {
            // Check that the value isn't already a port type.
            if (value is AnyPort port)
                return port;

            // If not, grab a list of all the port types
            // (types assignable to AnyPort)
            var types = typeof(AnyPort).Assembly.GetTypes().Where(t => typeof(AnyPort).IsAssignableFrom(t));

            // Now, we attempt to perform an implicit conversion to each type.
            foreach (var type in types)
            {
                if (TryImplicitConversion(value, type, out var converted))
                    return (AnyPort)converted;
            }

            // Fail if we couldn't convert the value.
            throw new Exception("Could not convert value to a port type!");
        }

        static bool TryImplicitConversion(object value, Type targetType, out object converted)
        {
            var valueType = value.GetType();

            // Collect implicit conversions from valueType to targetType
            var implicits = targetType.GetMethods().Where(m =>
            {
                if (m.Name != "op_Implicit" || !targetType.IsAssignableFrom(m.ReturnType))
                    return false;

                var parameters = m.GetParameters();
                return parameters.Length > 0 && valueType.IsAssignableFrom(parameters[0].ParameterType);
            });

            // Attempt to invoke each implicit conversion
            // until we find one that succeeds
            foreach (var method in implicits)
            {
                try
                {
                    var result = method.Invoke(targetType, new[] { value });
                    converted = result;
                    return true;
                }
                catch { }
            }

            // If we found none, fail.
            converted = null;
            return false;
        }
    }
}
