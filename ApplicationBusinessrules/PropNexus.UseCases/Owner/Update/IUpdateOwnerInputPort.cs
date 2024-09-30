using PropNexus.Dtos.Owners;

namespace PropNexus.UseCases.Owner.Update;

public interface IUpdateOwnerInputPort
{
    Task Handle(OwnerDto dto);
}