using Newtonsoft.Json;

namespace ObiletCase.Models.Request;

public class BrowserRequest
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("version")]
    public string Version { get; set; }
}