
namespace PropNexus.UseCases.Owner.Delete;

public interface IDeleteOwnerInputPort
{
    Task Handle(long id);
}