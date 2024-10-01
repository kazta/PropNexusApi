
namespace PropNexus.UseCases.PropertyImage.Get;

public interface IGetPropertyImageInputPort
{
    Task Handle(long id);
}