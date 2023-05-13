using BlazorApp.Shared;

namespace BlazorApp.Client.State.Projects;

public class FetchProjectsAction
{
    public IEnumerable<Project> Projects { get; }

    public FetchProjectsAction(IEnumerable<Project> projects) => Projects = projects;
}