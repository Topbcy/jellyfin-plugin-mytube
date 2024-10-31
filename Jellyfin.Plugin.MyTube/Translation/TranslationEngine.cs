using System.ComponentModel;

namespace Jellyfin.Plugin.MyTube.Translation;

public enum TranslationEngine
{
    [Description("Baidu")]
    Baidu,

    [Description("Google")]
    Google,

    [Description("Google (Free)")]
    GoogleFree,

    [Description("DeepL (Free)")]
    DeepL,

    [Description("OpenAI")]
    OpenAi
}
