// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("oXiVWALCYWT2GysOthm6IKQ9NeEtKybzCXrXbprlBgReooNicv+PcIcEF9CSVO6zLeTTCAS+sOXZu2B4E/V5HJgRT6kAMT3D0VXp6pQ2+enluL05m2398Ph6Dx0VU9y1arpjIGfF5iWxfaxtE1iZJY6jfwTFlys5EAYEsyeT0HjTj5lMwELqg5Y/X7/FyXRa9FceG/+tPljs0GsyYwRSK9HPeIMojrg/ULhLH8V+HrDZEcTaZV/qIUYkHVakydoZzV0LltSotwBM/n1eTHF6dVb6NPqLcX19fXl8f6tkJua96E3ZOEhxLTZS9yiEobl7/n1zfEz+fXZ+/n19fL/YO23IU4qiGOp58vIB/h66V4KVdViX4Evox91bv6VDyr0DvX5/fXx9");
        private static int[] order = new int[] { 5,13,3,9,4,11,6,7,12,10,11,12,13,13,14 };
        private static int key = 124;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
