using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Agent.Delete;

namespace PropNexus.Presenters.Agent;
public class DeleteAgentPresenter : IDeleteAgentOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}