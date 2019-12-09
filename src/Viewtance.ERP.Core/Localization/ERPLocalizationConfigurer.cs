﻿using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Viewtance.ERP.Localization
{
    public static class ERPLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ERPConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ERPLocalizationConfigurer).GetAssembly(),
                        "Viewtance.ERP.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
