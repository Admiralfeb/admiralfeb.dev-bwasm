using BlazorApp.Shared;

namespace BlazorApp.Client;

public sealed class HttpService : IHttpService
{
    private readonly HttpClient _http;

    public HttpService(HttpClient http) => _http = http;

    public async Task<IEnumerable<Project>> GetProjects()
    {
        throw new NotImplementedException();
    }

    public async Task<Resume> GetResume()
    {
        throw new NotImplementedException();
    }
}