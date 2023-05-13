using BlazorApp.Shared;

namespace BlazorApp.Client;

public interface IHttpService
{
    Task<IEnumerable<Project>> GetProjects();
    Task<Resume> GetResume();
}