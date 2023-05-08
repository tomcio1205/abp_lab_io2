using LABIO.Debugging;

namespace LABIO
{
    public class LABIOConsts
    {
        public const string LocalizationSourceName = "LABIO";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b9429cb6b26443e9ac3bc6d2ba34dcc5";
    }
}
