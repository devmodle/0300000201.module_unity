// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("emTTKIMlE5T7E+C0btW1G3K6b3FOExaSMMZWW1PRpLa++HcewRHIiwrTPvOpacrPXbCApR2yEYsPlp5KAM+NTRZD5nKT49qGnflcgy8KEtC4XtK3M7rkAqualmh6/kJBP51SQrutrxiMOHvTeCQy52vpQSg9lPQUCbNB0llZqlW1EfwpPt7zPEvgQ2zO9EGK7Y+2/Q9icbJm9qA9fwMcq+dV1vXn2tHe/VGfUSDa1tbW0tfUzG5NjhrWB8a48zKOJQjUr248gJKGgI1YotF8xTFOra/1CSjJ2VQk2yyvvHs5/0UYhk94o68VG05yEMvTbmLf8V/8tbBUBpXzR3vAmciv+YBV1tjX51XW3dVV1tbXFHOQxmP4IXbwFA7oYRaoFtXU1tfW");
        private static int[] order = new int[] { 12,4,5,8,9,6,6,10,12,11,13,12,13,13,14 };
        private static int key = 215;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
