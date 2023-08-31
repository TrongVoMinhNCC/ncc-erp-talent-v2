using TalentV2.Debugging;

namespace TalentV2
{
    public class TalentV2Consts
    {
        public const string LocalizationSourceName = "TalentV2";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1c0bf656fc5b4c6b8b5a9a1ea68bee36";
    }
}
