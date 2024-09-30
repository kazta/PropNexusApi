
namespace PropNexus.UseCases.Owner.Delete;

public interface IDeleteOwnerOutputPort
{
    Task Handle(bool success);
}