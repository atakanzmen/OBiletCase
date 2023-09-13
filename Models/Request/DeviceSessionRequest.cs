using Newtonsoft.Json;

namespace ObiletCase.Models.Request;

public class DeviceSessionRequest
{
    [JsonProperty("session-id")]
    public string SessionId { get; set; }

    [JsonProperty("device-id")]
    public string DeviceId { get; set; }
}