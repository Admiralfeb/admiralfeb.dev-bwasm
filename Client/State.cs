using BlazorApp.Shared;
namespace BlazorApp.Client;
public class StateContainer
{
    private Resume? _resume;
    private IEnumerable<Project>? _projects;

    public Resume? ResumeItem
    {
        get => _resume;
        set
        {
            _resume = value;
            NotifyStateChanged();
        }
    }

    public IEnumerable<Project> Projects
    {
        get => _projects ?? new List<Project>();
        set
        {
            _projects = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
