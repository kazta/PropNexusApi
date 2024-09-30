
namespace PropNexus.UseCases.Client.Delete;

public interface IDeleteClientOutputPort
{
    Task Handle(bool success);
}