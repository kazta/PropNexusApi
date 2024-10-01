
namespace PropNexus.UseCases.Client.Update;

public interface IUpdateClientOutputPort
{
    Task Handle(bool success);
}