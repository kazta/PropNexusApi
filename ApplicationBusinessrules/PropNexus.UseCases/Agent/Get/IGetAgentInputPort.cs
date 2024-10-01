
namespace PropNexus.UseCases.Agent.Get;

public interface IGetAgentInputPort
{
    Task Handle(long id);
}