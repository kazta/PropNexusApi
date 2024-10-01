
namespace PropNexus.UseCases.Agent.Delete;

public interface IDeleteAgentOutputPort
{
    Task Handle(bool success);
}