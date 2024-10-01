using PropNexus.Dtos.Owners;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Owner.Update;

public class UpdateOwnerInteractor(IUpdateOwnerOutputPort outputPort, IOwnerRepository repository) : IUpdateOwnerInputPort
{
    public async Task Handle(OwnerDto dto)
    {
        var entity = await repository.GetByIdAsync(dto.Id);

        if (entity is null)
        {
            await outputPort.Handle(false);
            return;
        }

        entity.FirstName = dto.FirstName;
        entity.LastName = dto.LastName;
        entity.Email = dto.Email;
        entity.Phone = dto.Phone;

        await repository.UpdateAsync(entity);
        await outputPort.Handle(true);
    }
}
