using PropNexus.Dtos.Owners;

namespace PropNexus.UseCases.Owner.Create;

public interface ICreateOwnerInputPort
{
    Task Handle(OwnerDto dto);
}