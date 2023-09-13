using Newtonsoft.Json;

namespace ObiletCase.Models.Request;

public class GetSessionRequest
{
    [JsonProperty("type")]
    public int Type { get; set; }

    [JsonProperty("connection")]
    public ConnectionRequest Connection { get; set; }

    [JsonProperty("browser")]
    public BrowserRequest Browser { get; set; }
}