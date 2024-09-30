
namespace PropNexus.UseCases.Agent.Create;

public interface ICreateAgentOutputPort
{
    Task Handle(bool success);
}