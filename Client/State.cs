using BlazorApp.Shared;
namespace BlazorApp.Client;
public class StateContainer
{
    private Resume? resume;
    private List<Project>? projects;

    public Resume? ResumeItem
    {
        get => resume;
        set
        {
            resume = value;
            NotifyStateChanged();
        }
    }

    public List<Project> Projects
    {
        get => projects ?? new();
        set
        {
            projects = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
