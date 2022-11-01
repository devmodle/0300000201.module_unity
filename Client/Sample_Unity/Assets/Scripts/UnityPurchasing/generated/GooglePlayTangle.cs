// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("wENQl9UTqfRqo5RPQ/n3op78Jz+5OjQ7C7k6MTm5Ojo7+J98Ko8UzeVfrT61tUa5Wf0QxdIyH9CnDK+AC7k6GQs2PTIRvXO9zDY6Ojo+OziCjjMdsxBZXLjqeR+rlyx1JEMVbOY/0h9FhSYjsVxsSfFe/WfjenKmlog/xG/J/3gX/wxYgjlZ955Wg53sI2Gh+q8Knn8PNmpxFbBvw+b+PCIYrWYBY1oR446dXooaTNGT7/BHVLI+W99WCO5HdnqElhKurdNxvq5qbGG0Tj2QKd2iQUMZ5cQlNbjIN6L/+n7cKrq3vz1IWlIUm/It/SRnV0FD9GDUlz+UyN4LhwWtxNF4GPgggqFi9jrrKlQf3mLJ5DhDgtBsfpoc+OIEjfpE+jk4Ojs6");
        private static int[] order = new int[] { 3,1,2,3,7,5,12,8,10,9,13,13,12,13,14 };
        private static int key = 59;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
