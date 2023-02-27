using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ASP.NETMyProject.Localization
{
    public static class NETMyProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(NETMyProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NETMyProjectLocalizationConfigurer).GetAssembly(),
                        "ASP.NETMyProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
