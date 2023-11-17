using System.Text.RegularExpressions;

namespace RRCG
{
    internal class SanitizeUtils
    {
        // returns a sanitized and safe-to-use string for cv2 chip names 
        public static string SantizeCV2Name(string name)
        {
            return new Regex("[^a-zA-Z0-9-]").Replace(name, "").Replace(" ", "");
        }
    }
}
