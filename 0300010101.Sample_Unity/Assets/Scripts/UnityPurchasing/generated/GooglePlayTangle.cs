// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("mhe2+hIa6Yl8+MSQn+m8YtkX1anTWW4bFilkmlbwuWZElsTft1pm/gEHk2LzR9lVE3YTeODv0a7UtYXl72xibV3vbGdv72xsbbjxlS7nUUPeDsl5GDGlkXv+T3gEX/EvaQsi0Ovoq6VUC5mtLhY5CT1F6FU+vPbZJpGtBMDoSNxeABe4UsSJTOLF+cWcWexQ37Spiip/bTVJbPDvW9UoWF3vbE9dYGtkR+sl65pgbGxsaG1uLPaWdamjowXLbkgytcWgwqPcrWwixi8id3wlXD3nLz6PPZpScPO57HK059Dw39e0PcErB4g36XJnEKUx8fvHP/tbwwOpbJMXB4RP4MTrggpqIoWEzDx6P1nWv5nSdmGDRotd9ZLCY2bRspGDxG9ubG1s");
        private static int[] order = new int[] { 10,8,4,8,13,12,13,12,10,12,11,13,12,13,14 };
        private static int key = 109;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
