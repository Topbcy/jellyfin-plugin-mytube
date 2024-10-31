using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.MyTube.Metadata;

public class ActorSearchResult : ProviderInfo
{
    [JsonPropertyName("images")]
    public string[] Images { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}
