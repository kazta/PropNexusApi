using PropNexus.Dtos.Client;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Client.Get;
public class GetClientInteractor(IGetClientOutputPort outputPort, IClientRepository repository) : IGetClientInputPort
{
    public async Task Handle(long id)
    {
        var entity = await repository.GetByIdAsync(id);

        if (entity is null)
        {
            await outputPort.Handle(null);
            return;
        }

        var dto = new ClientDto
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