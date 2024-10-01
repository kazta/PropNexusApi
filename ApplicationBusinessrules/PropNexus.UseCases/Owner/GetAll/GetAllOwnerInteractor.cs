using PropNexus.Dtos.Owners;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Owner.GetAll;
public class GetAllOwnerInteractor(IGetAllOwnerOutputPort outputPort, IOwnerRepository repository) : IGetAllOwnerInputPort
{
    public async Task Handle()
    {
        var entities = await repository.GetAllAsync();
        var dtos = entities.Select(entity => new OwnerDto
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            Phone = entity.Phone
        });

        await outputPort.Handle(dtos);
    }
}