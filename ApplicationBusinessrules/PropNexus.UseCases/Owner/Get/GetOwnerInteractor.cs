using PropNexus.Dtos.Owners;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Owner.Get;
public class GetOwnerInteractor(IGetOwnerOutputPort outputPort, IOwnerRepository repository) : IGetOwnerInputPort
{
    public async Task Handle(long id)
    {
        var entity = await repository.GetByIdAsync(id);

        if (entity is null)
        {
            await outputPort.Handle(null);
            return;
        }

        var dto = new OwnerDto
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            Phone = entity.Phone
        };

        await outputPort.Handle(dto);
    }
}
