using Newtonsoft.Json;

namespace ObiletCase.Models.Response;

public class ApiResponse<T>
{
    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("data")]
    public T Data { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }
}