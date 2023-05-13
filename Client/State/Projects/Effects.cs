using Fluxor;

namespace BlazorApp.Client.State.Projects;

public class Effects
{
    private readonly IHttpService _http;

    public Effects(IHttpService http) => _http = http;

    [EffectMethod(typeof(FetchProjectsAction))]
    public async Task FetchFromServer(IDispatcher dispatcher)
    {
        var projects = await _http.GetProjects();
        dispatcher.Dispatch(new FetchProjectsAction(projects));
    }
}