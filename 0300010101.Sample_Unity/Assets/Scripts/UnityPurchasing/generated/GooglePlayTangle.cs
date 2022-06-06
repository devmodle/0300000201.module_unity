// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("4jL1RSQNma1HwnNEOGPNE1U3HuxOiNvszOPriAH9Fzu0C9VOWyyZDRqtkTj81HTgYjwrhG74tXDe+cX5YdNQc2FcV1h71xnXplxQUFBUUVLvZVInKhVYpmrMhVp4qvjji2ZawtfUl5loN6WREioFNQF51GkCgMrlHvoTHktAGWAB2xMCswGmbkzPhdBWHrm48ABGA2Xqg6XuSl2/erdhyc3H+wPHZ/8/lVCvKzu4c9z4174201BeUWHTUFtT01BQUYTNqRLbbX8QyqpJlZ+fOfdSdA6J+Zz+n+CRUKYrisYuJtW1QMT4rKPVgF7lK+mVPTuvXs975WkvSi9E3NPtkuiJudmgZdBs44iVthZDUQl1UMzTZ+kUZK7+X1rtjq2/+FNSUFFQ");
        private static int[] order = new int[] { 13,6,2,13,8,12,11,13,9,11,13,13,13,13,14 };
        private static int key = 81;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
