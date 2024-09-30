using PropNexus.Dtos.Agent;

namespace PropNexus.UseCases.Agent.Update;

public interface IUpdateAgentInputPort
{
    Task Handle(AgentDto dto);
}