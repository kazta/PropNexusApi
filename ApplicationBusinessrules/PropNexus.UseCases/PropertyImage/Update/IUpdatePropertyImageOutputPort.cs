
namespace PropNexus.UseCases.PropertyImage.Update;

public interface IUpdatePropertyImageOutputPort
{
    Task Handle(bool success);
}