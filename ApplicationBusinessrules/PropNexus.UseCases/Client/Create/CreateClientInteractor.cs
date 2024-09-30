using PropNexus.Dtos.Client;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Client.Create;
public class CreateClientInteractor(ICreateClientOutputPort outputPort, IClientRepository repository) : ICreateClientInputPort
{
    public async Task Handle(ClientDto dto)
    {
        var entity = new Entities.Models.Client
        {
            Id = dto.Id,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            Phone = dto.Phone
        };

        await repository.AddAsync(entity);
        await outputPort.Handle(true);
    }
}