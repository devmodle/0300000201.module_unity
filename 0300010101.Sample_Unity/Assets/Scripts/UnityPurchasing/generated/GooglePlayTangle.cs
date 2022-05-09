// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("NbgZVb21RibTV2s/MEYTzXa4egauqDzNXOh2+rzZvNdPQH4BexoqSjP2Q/9wGwYlhdDCmubDX0D0eof3xY0qK2OT1ZD2eRA2fdnOLOkk8lqNaYCN2NOK85JIgJEgkjX931wWQ90bSH9fcHgbkm6EqCeYRt3IvwqeREcECvukNgKBuZamkupH+pETWXZeVGiQVPRsrAbDPLioK+BPa0QtpfJAw+Dyz8TL6ESKRDXPw8PDx8LBfPbBtLmGyzX5XxbJ6zlrcBj1yVGJPgKrb0fnc/GvuBf9aybjTWpWanGhZta3ngo+1FHg16vwXoDGpI1/g1k52gYMDKpkweedGmoPbQxzAsNAw83C8kDDyMBAw8PCF146gUj+7D1tzMl+HT4sa8DBw8LD");
        private static int[] order = new int[] { 10,4,5,3,11,6,12,9,10,10,12,13,12,13,14 };
        private static int key = 194;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
