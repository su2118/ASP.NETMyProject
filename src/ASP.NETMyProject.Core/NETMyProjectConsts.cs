using ASP.NETMyProject.Debugging;

namespace ASP.NETMyProject
{
    public class NETMyProjectConsts
    {
        public const string LocalizationSourceName = "NETMyProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "914c6cdc6159409cac174aea7ade3d91";
    }
}
