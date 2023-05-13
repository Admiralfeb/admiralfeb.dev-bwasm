using BlazorApp.Shared;
using Fluxor;

namespace BlazorApp.Client.State.Projects;

[FeatureState]
public class State
{
    public IEnumerable<Project> Projects { get; }

    public State()
    {
        Projects = new List<Project>();
    }

    public State(IEnumerable<Project> projects) => Projects = projects;
}