using PropNexus.Dtos.Owners;

namespace PropNexus.UseCases.Owner.Get;

public interface IGetOwnerOutputPort
{
    Task Handle(OwnerDto? dto);
}