
namespace PropNexus.UseCases.Owner.Create;

public interface ICreateOwnerOutputPort
{
    Task Handle(bool success);
}