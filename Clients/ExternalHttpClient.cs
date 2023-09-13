using ObiletCase.Extensions;
using ObiletCase.Models.Request;
using ObiletCase.Models.Response;

namespace ObiletCase.Clients;

public class ExternalHttpClient
{
    private readonly HttpClient _httpClient;
    public ExternalHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResponse<List<BusJourney>>> GetJourneys(BusJourneyRequest model)
    {
        return await _httpClient.Post<ApiResponse<List<BusJourney>>>($"api/journey/getbusjourneys", model);
    }

    public async Task<ApiResponse<Session>> GetSession(GetSessionRequest session)
    {
        return await _httpClient.Post<ApiResponse<Session>>($"api/client/getsession", session);
    }

    public async Task<ApiResponse<List<BusLocation>>> GetBusLocation(BusLocationRequest request)
    {
        return await _httpClient.Post<ApiResponse<List<BusLocation>>>($"/api/location/getbuslocations", request);
    }
}
