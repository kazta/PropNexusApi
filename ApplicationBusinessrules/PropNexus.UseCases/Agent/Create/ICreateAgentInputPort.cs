using PropNexus.Dtos.Agent;

namespace PropNexus.UseCases.Agent.Create;

public interface ICreateAgentInputPort
{
    Task Handle(AgentDto dto);
}