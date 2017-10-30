/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace BowenSerene.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('_Ext');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}