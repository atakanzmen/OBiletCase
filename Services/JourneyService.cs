using ObiletCase.Clients;
using ObiletCase.Models.Request;
using ObiletCase.Models.Response;

namespace ObiletCase.Services;

public class JourneyService
{
    private readonly ExternalHttpClient _externalHttpClient;
    private readonly ApplicationSettings _applicationSettings;

    public JourneyService(ExternalHttpClient externalHttpClient, ApplicationSettings applicationSettings)
    {
        _externalHttpClient = externalHttpClient;
        _applicationSettings = applicationSettings;
    }

    public async Task<List<BusJourney>> GetJourneys(JourneyDataRequest data)
    {

        var request = new BusJourneyRequest
        {
            DeviceSession = _applicationSettings.DeviceSession,
            Data = data,
            Language = "tr-TR"
        };

        var response = await _externalHttpClient.GetJourneys(request);
        return response.Data;
    }
}