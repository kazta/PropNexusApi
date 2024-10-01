using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Agent.Update;

namespace PropNexus.Presenters.Agent;
public class UpdateAgentPresenter : IUpdateAgentOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}