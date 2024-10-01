using PropNexus.Dtos.Client;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Client.GetAll;
public class GetAllClientInteractor(IGetAllClientOutputPort outputPort, IClientRepository repository) : IGetAllClientInputPort
{
    public async Task Handle()
    {
        var entities = await repository.GetAllAsync();
        var dtos = entities.Select(entity => new ClientDto
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