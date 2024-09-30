
namespace PropNexus.UseCases.PropertyImage.Create;

public interface ICreatePropertyImageOutputPort
{
    Task Handle(bool success);
}