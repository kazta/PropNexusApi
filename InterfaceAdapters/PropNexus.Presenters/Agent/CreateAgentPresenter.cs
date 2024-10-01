using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Agent.Create;

namespace PropNexus.Presenters.Agent;
public class CreateAgentPresenter : ICreateAgentOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}