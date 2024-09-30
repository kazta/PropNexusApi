using PropNexus.Dtos.Agent;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Agent.GetAll;

namespace PropNexus.Presenters.Agent;
public class GetAllAgentPresenter : IGetAllAgentOutputPort, IPresenter<IEnumerable<AgentDto>>
{
    public IEnumerable<AgentDto> Content { get; private set; } = Enumerable.Empty<AgentDto>();

    public Task Handle(IEnumerable<AgentDto> dtos)
    {
        Content = dtos;
        return Task.CompletedTask;
    }
}