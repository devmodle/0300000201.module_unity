// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("0Te73lrTjWvC8/8BE5crKFb0Oytg2ii7MDDDPNx4lUBXt5pVIokqBdLExnHlURK6EU1bjgKAKEFU/Z19Y7pXmsAAo6Y02enMdNt44mb/9yOnnSjjhObflGYLGNsPn8lUFmp1wqUHJOdzv26v0Zpb50xhvcYHVen7RcbVElCWLHHvJhHKxnxyJxt5oroHC7aYNpXc2T1v/JouEqnwocaQ6RMNukHqTHr9knqJ3Qe83HIb0wYYjjy/nI6zuLeUOPY4SbO/v7+7vr08v7G+jjy/tLw8v7++fRr5rwqRSGmm5CR/Ko8b+oqz7/SQNepGY3u57+nkMcu4FaxYJ8TGnGBBoLA9TbInen/7Wa8/Mjq4zd/XkR53qHih4h+ZfWeBCH/Bf7y9v76/");
        private static int[] order = new int[] { 9,2,6,5,10,11,11,7,12,9,11,12,13,13,14 };
        private static int key = 190;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
