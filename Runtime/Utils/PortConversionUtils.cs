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
    }
}
