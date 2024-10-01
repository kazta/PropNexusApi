using PropNexus.Dtos.Owners;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Owner.Create;
public class CreateOwnerInteractor(ICreateOwnerOutputPort outputPort, IOwnerRepository repository) : ICreateOwnerInputPort
{
    public async Task Handle(OwnerDto dto)
    {
        var entity = new Entities.Models.Owner
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