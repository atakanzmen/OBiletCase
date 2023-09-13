using Newtonsoft.Json;

namespace ObiletCase.Models.Response;

public class Session
{
    [JsonProperty("session-id")]
    public string SessionId { get; set; }

    [JsonProperty("device-id")]
    public string DeviceId { get; set; }

    [JsonProperty("affiliate")]
    public string Affiliate { get; set; }

    [JsonProperty("device-type")]
    public long DeviceType { get; set; }

    [JsonProperty("device")]
    public string Device { get; set; }
}