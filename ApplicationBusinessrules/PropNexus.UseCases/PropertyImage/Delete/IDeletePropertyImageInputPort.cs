
namespace PropNexus.UseCases.PropertyImage.Delete;

public interface IDeletePropertyImageInputPort
{
    Task Handle(long id);
}