
namespace PropNexus.UseCases.Agent.Update;

public interface IUpdateAgentOutputPort
{
    Task Handle(bool success);
}