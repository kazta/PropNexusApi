
namespace PropNexus.UseCases.Client.Get;

public interface IGetClientInputPort
{
    Task Handle(long id);
}