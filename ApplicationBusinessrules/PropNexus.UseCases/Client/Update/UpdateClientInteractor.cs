using PropNexus.Dtos.Client;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Client.Update;
public class UpdateClientInteractor(IUpdateClientOutputPort outputPort, IClientRepository repository) : IUpdateClientInputPort
{
    public async Task Handle(ClientDto dto)
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