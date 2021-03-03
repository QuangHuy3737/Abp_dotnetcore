using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HuyWebStore.Localization
{
    public static class HuyWebStoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HuyWebStoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HuyWebStoreLocalizationConfigurer).GetAssembly(),
                        "HuyWebStore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
