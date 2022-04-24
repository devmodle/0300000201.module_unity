// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("BMKRpoapocJLt11x/kGfBBFm00elLxhtYF8S7CCGzxAy4LKpwSwQiOxhwIxkbJ//Co6y5umfyhSvYaPfHFTz8rpKDEkvoMnvpAAX9TD9K4OoeL8PbkfT5w2IOQ5yKYdZH31UpoeNsUmNLbV13xrlYXHyOZaynfR8d3HlFIUxryNlAGUOlpmn2KLD85Odnt3TIn3v21hgT39LM54jSMqAr1qA4APf1dVzvRg+RMOz1rTVqtsaK5kaOSsWHRIxnVOd7BYaGhoeGxiZGhQbK5kaERmZGhobzofjWJEnNeovmiapwt/8XAkbQz8ahpkto14uVLBZVAEKUypLkVlI+UvsJAaFz5pQ59tytp4+qih2Yc4ksv86lLOPs+S0FRCnxOf1shkYGhsa");
        private static int[] order = new int[] { 6,8,10,3,13,9,13,12,12,13,12,13,13,13,14 };
        private static int key = 27;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
