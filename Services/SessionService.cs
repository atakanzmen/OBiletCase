using ObiletCase.Clients;
using ObiletCase.Models.Request;
using ObiletCase.Models.Response;

namespace ObiletCase.Services;

public class SessionService
{
    private readonly ExternalHttpClient _externalHttpClient;
    private readonly ApplicationSettings _applicationSettings;

    public SessionService(ExternalHttpClient externalHttpClient, ApplicationSettings applicationSettings)
    {
        _externalHttpClient = externalHttpClient;
        _applicationSettings = applicationSettings;
    }

    public async Task<Session> GetSession()
    {
        var request = new GetSessionRequest
        {
            Browser = new()
            {
                Name = "Chrome",
                Version = "108.0.0"
            },
            Connection = new()
            {
                IpAddress = "127.0.0.1",
                Port = "11544"
            },
            Type = 1
        };

        var response = await _externalHttpClient.GetSession(request);
        _applicationSettings.DeviceSession = new DeviceSessionRequest()
        {
            DeviceId = response.Data.DeviceId,
            SessionId = response.Data.SessionId
        };
        return response.Data;
    }
}
