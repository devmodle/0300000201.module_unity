// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("HqwvDB4jKCcEqGao2SMvLy8rLi2sLyEuHqwvJCysLy8u+7LWbaQSAKir6OYXSNrubVV6Sn4GqxZ9/7WaKWHGx49/OXwalfzakTUiwAXIHrbZVPW5UVmqyj+7h9Pcqv8hmlSW6t8arxOc9+rJaTwudgovs6wYlmsbQkTQIbAEmhZQNVA7o6yS7Zf2xqZvtdU26uDgRogtC3H2huOB4J/uL2XS7keDqwufHUNU+xGHyg+hhrqGYYVsYTQ/Zh9+pGx9zH7ZETOw+q+yuIR8uBiAQOov0FRExwyjh6jBSTH3pJOznJT3foJoRMt0qjEkU+ZykBotWFVqJ9kVs/olB9WHnPQZJb2dTYo6W3Lm0ji9DDtHHLJsKkhhk9GBICWS8dLAhywtLy4v");
        private static int[] order = new int[] { 0,1,12,3,10,5,10,7,12,11,11,11,12,13,14 };
        private static int key = 46;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
