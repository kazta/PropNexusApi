
namespace PropNexus.UseCases.Property.Delete;

public interface IDeletePropertyOutputPort
{
    Task Handle(bool success);
}