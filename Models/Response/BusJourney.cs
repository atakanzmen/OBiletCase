using Newtonsoft.Json;

namespace ObiletCase.Models.Response;

public class BusJourney
{
	[JsonProperty("partner-name")]
	public string PartnerName { get; set; }

	[JsonProperty("bus-type")]
	public string BusType { get; set; }

	[JsonProperty("journey")]
	public Journey Journey { get; set; }

	[JsonProperty("origin-location")]
	public string OriginLocation { get; set; }

	[JsonProperty("destination-location")]
	public string DestinationLocation { get; set; }
}
