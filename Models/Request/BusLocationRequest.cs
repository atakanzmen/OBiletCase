using Newtonsoft.Json;

namespace ObiletCase.Models.Request;

public class BusLocationRequest
{
    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("device-session")]
    public DeviceSessionRequest DeviceSession { get; set; }
}