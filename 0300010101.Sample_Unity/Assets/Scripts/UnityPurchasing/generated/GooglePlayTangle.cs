// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("+HJFMD0CT7F925JNb73v9JxxTdXER0lGdsRHTETER0dGk9q+Bcx6aLE8ndE5McKiV9Pvu7TCl0nyPP6CCe0ECVxXDncWzAQVpBaxeVvYkscH3b1egoiILuBFYxme7ovpiPeGRyosuEnYbPJ+OF04U8vE+oX/nq7O2tDsFNBw6CiCR7g8LK9ky+/AqSH1JeJSMxqOulDVZFMvdNoEQiAJ+8DDgI5/ILKGBT0SIhZuw34Vl93yDbqGL+vDY/d1KzyTee+iZ8nu0u5Zn8z72/T8nxbqACyjHMJZTDuOGnbER2R2S0BPbMAOwLFLR0dHQ0ZFt3LHe/SfgqEBVEYeYkfbxHD+A3NBCa6v5xdRFHL9lLL5XUqobaB23rnpSE36mbqo70RFR0ZH");
        private static int[] order = new int[] { 8,1,10,11,7,7,9,13,12,10,10,12,13,13,14 };
        private static int key = 70;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
