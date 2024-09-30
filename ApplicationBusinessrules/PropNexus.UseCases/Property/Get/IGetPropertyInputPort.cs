
namespace PropNexus.UseCases.Property.Get;

public interface IGetPropertyInputPort
{
    Task Handle(long id);
}