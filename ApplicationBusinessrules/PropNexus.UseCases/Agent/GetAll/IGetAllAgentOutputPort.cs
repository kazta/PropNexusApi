using PropNexus.Dtos.Agent;

namespace PropNexus.UseCases.Agent.GetAll;

public interface IGetAllAgentOutputPort
{
    Task Handle(IEnumerable<AgentDto> dtos);
}