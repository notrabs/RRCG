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
    }
}
