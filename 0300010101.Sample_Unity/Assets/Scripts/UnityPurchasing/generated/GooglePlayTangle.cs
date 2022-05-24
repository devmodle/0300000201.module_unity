// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("VVPHNqcTjQFHIkcstLuF+oDh0bF4osIh/ff3UZ86HGbhkfSW94j5OIpanS1MZfHFL6obLFALpXs9X3aEzkPirkZOvd0orJDEy73oNo1Dgf2/vP/xAF/N+XpCbV1pEbwBauiijXaSe3YjKHEIabN7attpzgYkp+24PnbR0JhoLmsNguvNhiI11xLfCaGlr5Nrrw+XV/04x0NT0Bu0kL/WXocNOk9CfTDOAqTtMhDCkIvjDjKquzg2OQm7ODM7uzg4OeylwXqzBRdyxflQlLwciApUQ+wGkN0YtpGtkQm7OBsJND8wE79xv840ODg4PDk6JuCzhKSLg+BplX9T3GO9JjNE8WXIDbgEi+D93n4rOWEdOKS7D4F8DMaWNzKF5sXXkDs6ODk4");
        private static int[] order = new int[] { 4,7,13,10,12,11,10,9,8,9,13,12,13,13,14 };
        private static int key = 57;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
