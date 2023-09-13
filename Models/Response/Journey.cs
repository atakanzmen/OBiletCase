using Newtonsoft.Json;

namespace ObiletCase.Models.Response;

public class Journey
{
	[JsonProperty("departure")]
	public DateTime? Departure { get; set; }

	[JsonProperty("currency")]
	public string Currency { get; set; }

	[JsonProperty("internet-price")]
	public long InternetPrice { get; set; }

	[JsonProperty("features")]
	public List<string> Features { get; set; }
}