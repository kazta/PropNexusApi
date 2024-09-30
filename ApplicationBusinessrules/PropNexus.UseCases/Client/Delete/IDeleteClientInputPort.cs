
namespace PropNexus.UseCases.Client.Delete;

public interface IDeleteClientInputPort
{
    Task Handle(long id);
}