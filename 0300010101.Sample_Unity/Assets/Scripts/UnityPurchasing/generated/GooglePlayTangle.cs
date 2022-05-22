// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("pGIxBiYJAWLrF/3RXuE/pLHGc+fwR3vSFj6eCojWwW6EEl+aNBMvEz0+fXOC3U97+MDv3+uTPoPoaiAPJy0R6S2NFdV/ukXB0VKZNhI9VNxMwWAsxMw/X6ouEkZJP2q0D8EDf4s5upmLtr2ykT3zPUy2urq6vru4+iBAo391ddMduJ7kYxN2FHUKe7o5urS7izm6sbk5urq7bidD+DGHlfQQ+fShqvOK6zH56FnrTISmJW8619FFtCWRD4PFoMWuNjkHeAJjUzO89FNSGuqs6Y8AaU8EoLdVkF2LIwjYH6/O53NHrSiZrtKJJ/m/3fQGBY+4zcD/skyAJm+wkkASCWGMsChKjzqGCWJ/XPypu+OfuiY5jQP+jkQUtbAHZEdVErm4uru6");
        private static int[] order = new int[] { 6,2,12,9,10,6,7,12,11,10,10,13,13,13,14 };
        private static int key = 187;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
