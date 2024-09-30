using PropNexus.Dtos.Agent;

namespace PropNexus.UseCases.Agent.Get;

public interface IGetAgentOutputPort
{
    Task Handle(AgentDto? dto);
}