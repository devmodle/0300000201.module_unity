// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("ZHrNNp07DYrlDf6qcMurBWykcW+mQMypLaT6HLWEiHZk4FxfIYNMXJiek0a8z2LbL1CzsesXNtfHSjrF0OpflPORqOMRfG+seOi+I2EdArUe0ZNTCF34bI39xJiD50KdMRQMztJwU5AEyBnYpu0skDsWyrFwIp6MUA0IjC7YSEVNz7qooOZpAN8P1pX5S8jr+cTPwONPgU8+xMjIyMzJyqWzsQaSJmXNZjos+XX3XzYjiuoKS8jGyflLyMPLS8jIyQptjth95j9wfMHvQeKrrkoYi+1ZZd6H1rHnnjKxomUn4VsGmFFmvbELBVBsDtXNF61fzEdHtEurD+I3IMDtIlX+XXIUzSDtt3fU0UOunrsDrA+VEYiAVGjuChD2fwi2CMvKyMnI");
        private static int[] order = new int[] { 12,9,13,10,8,11,8,12,8,9,12,12,13,13,14 };
        private static int key = 201;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
