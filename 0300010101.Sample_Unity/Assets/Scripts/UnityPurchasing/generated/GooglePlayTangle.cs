// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("31ViFxolaJZa/LVqSJrI07tWavJR42BDUWxnaEvnKeeWbGBgYGRhYpYbuvYeFuWFcPTInJPlsG7VG9ml0gLFdRQ9qZ138kN0CFP9I2UHLtzjYG5hUeNga2PjYGBhtP2ZIutdT36469z809u4Mc0nC4Q75X5rHKk9Kp2hCMzkRNBSDBu0XsiFQO7J9cn998sz91fPD6VgnxsLiEPsyOeOBmYuiYjAMHYzVdqzld56bY9Kh1H5DQufbv9L1Vkfeh907OPdoti5iekg+pp5pa+vCcdiRD65yazOr9ChYJBV4FzTuKWGJnNhOUVg/ONX2SRULsojLntwKVAx6yMygzGWXnz/teDn5KepWAeVoSIaNQUxSeRZMrD61Z7Ob2rdvp2PyGNiYGFg");
        private static int[] order = new int[] { 8,8,10,13,8,6,10,9,13,13,13,13,13,13,14 };
        private static int key = 97;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
