
namespace PropNexus.UseCases.PropertyImage.Delete;

public interface IDeletePropertyImageOutputPort
{
    Task Handle(bool success);
}