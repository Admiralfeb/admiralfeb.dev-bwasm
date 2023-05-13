
using ResumeObj = BlazorApp.Shared.Resume;
using BlazorApp.Shared;
using Fluxor;

namespace BlazorApp.Client.State.Resume;

[FeatureState]
public class State
{
    public ResumeObj Resume { get; }

    public State()
    {
        Resume = new ResumeObj(new List<Experience>(), new List<SkillItem>());
    }

    public State(ResumeObj resume) => Resume = resume;
}