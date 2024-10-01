using PropNexus.Dtos.Owners;

namespace PropNexus.UseCases.Owner.GetAll;

public interface IGetAllOwnerOutputPort
{
    Task Handle(IEnumerable<OwnerDto> dtos);
}