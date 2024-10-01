
namespace PropNexus.UseCases.Owner.Get;

public interface IGetOwnerInputPort
{
    Task Handle(long id);
}