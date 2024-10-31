using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.MyTube.Metadata;

public class ErrorInfo
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}
