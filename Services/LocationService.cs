using ObiletCase.Clients;
using ObiletCase.Models.Request;
using ObiletCase.Models.Response;

namespace ObiletCase.Services;

public class LocationService
{
    private readonly ExternalHttpClient _externalHttpClient;
    private readonly ApplicationSettings _applicationSettings;

    public LocationService(ExternalHttpClient externalHttpClient, ApplicationSettings applicationSettings)
    {
        _externalHttpClient = externalHttpClient;
        _applicationSettings = applicationSettings;
    }

    public async Task<List<BusLocation>> GetBusLocations()
    {

        var request = new BusLocationRequest
        {
            DeviceSession = _applicationSettings.DeviceSession,
            Language = "tr-TR"
        };

        var response = await _externalHttpClient.GetBusLocation(request);
        return response.Data;
    }
}