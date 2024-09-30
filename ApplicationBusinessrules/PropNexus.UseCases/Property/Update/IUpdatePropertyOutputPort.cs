
namespace PropNexus.UseCases.Property.Update;

public interface IUpdatePropertyOutputPort
{
    Task Handle(bool success);
}