
namespace PropNexus.UseCases.Client.Create;

public interface ICreateClientOutputPort
{
    Task Handle(bool success);
}