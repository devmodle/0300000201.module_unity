// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("G8GhQp6UlDL8WX8FgvKX9ZTrmltFg9Dnx+jggwr2HDC/AN5FUCeSBqtu22fog569HUhaAn5bx9hs4h9vXRWys/sLTQhu4Yiu5UFWtHG8asLkblksIR5TrWHHjlFzofPogG1RycbM8AjMbPQ0nlukIDCzeNfz3LU9athbeGpXXFNw3BLcrVdbW1tfWlkV8RgVQEsSawrQGAm4Cq1lR8SO29hbVVpq2FtQWNhbW1qPxqIZ0GZ06Tn+Ti8GkqZMyXhPM2jGGF48FecRppoz999/62k3II9l87571fLO8jYwpFXEcO5iJEEkT9fY5pnjgrLSrSCBzSUt3r5Lz/OnqN6LVe4g4p7c35ySYzyumhkhDj4Kct9iCYvB7qX1VFHmhaa081hZW1pb");
        private static int[] order = new int[] { 7,6,5,3,8,9,7,11,11,13,13,11,13,13,14 };
        private static int key = 90;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
