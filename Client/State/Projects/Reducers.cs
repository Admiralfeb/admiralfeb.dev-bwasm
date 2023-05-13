using Fluxor;

namespace BlazorApp.Client.State.Projects;

public static class Reducers
{
    [ReducerMethod]
    public static State ReduceFetchProjects(State state, FetchProjectsAction action) =>
        new(action.Projects);
}