using System.ComponentModel;

namespace Jellyfin.Plugin.MyTube.Translation;

public enum TranslationMode
{
    [Description("Disabled")]
    Disabled,

    [Description("Title")]
    Title,

    [Description("Summary")]
    Summary,

    [Description("Title and Summary")]
    Both
}
