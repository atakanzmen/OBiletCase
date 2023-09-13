using Newtonsoft.Json;

namespace ObiletCase.Models.Request;

public class BusJourneyRequest
{
    public string Language { get; set; }
    public JourneyDataRequest Data { get; set; }

    [JsonProperty("device-session")]
    public DeviceSessionRequest DeviceSession { get; set; }
}

public class JourneyDataRequest
{
    public int OriginId { get; set; }
    public int DestinationId { get; set; }
    public string DepartureDate { get; set; }
}