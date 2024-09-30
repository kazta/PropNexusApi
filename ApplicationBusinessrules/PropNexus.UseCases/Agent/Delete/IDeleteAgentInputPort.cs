
namespace PropNexus.UseCases.Agent.Delete;

public interface IDeleteAgentInputPort
{
    Task Handle(long id);
}