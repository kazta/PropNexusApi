using PropNexus.Dtos.Agent;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Agent.Get;

namespace PropNexus.Presenters.Agent;
public class GetAgentPresenter : IGetAgentOutputPort, IPresenter<AgentDto?>
{
    public AgentDto? Content { get; private set; }

    public Task Handle(AgentDto? dto)
    {
        Content = dto;
        return Task.CompletedTask;
    }
}