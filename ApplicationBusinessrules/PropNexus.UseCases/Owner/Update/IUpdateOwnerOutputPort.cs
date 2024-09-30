
namespace PropNexus.UseCases.Owner.Update;

public interface IUpdateOwnerOutputPort
{
    Task Handle(bool success);
}