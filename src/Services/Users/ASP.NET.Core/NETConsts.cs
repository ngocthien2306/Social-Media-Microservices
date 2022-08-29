using ASP.NET.Debugging;

namespace ASP.NET
{
    public class NETConsts
    {
        public const string LocalizationSourceName = "NET";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "802435c554864df4846143f9c87519a2";
    }
}
