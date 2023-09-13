using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace ObiletCase.Extensions;

public static class HttpClientExtensions
{
    public static async Task<T> Post<T>(this HttpClient httpClient, string url, object model) where T : class
    {
        var modelContent = JsonConvert.SerializeObject(model);
        var buffer = Encoding.UTF8.GetBytes(modelContent);
        var byteContent = new ByteArrayContent(buffer);
        byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        var response = await httpClient.PostAsync(url, byteContent);
        var stringContent = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(stringContent);
    }
}