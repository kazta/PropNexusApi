using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Property.Create;
public class CreatePropertyInteractor(ICreatePropertyOutputPort outputPort, IPropertyRepository repository) : ICreatePropertyInputPort
{
    public async Task Handle(PropertyDto dto)
    {
        var entity = new Entities.Models.Property
        {
            Id = dto.Id,
            Address = dto.Address,
            City = dto.City,
            State = dto.State,
            ZipCode = dto.ZipCode,
            Price = dto.Price,
            Bedrooms = dto.Bedrooms,
            Bathrooms = dto.Bathrooms,
            SquareFeet = dto.SquareFeet,
            PropertyType = dto.PropertyType,
            Description = dto.Description,
            OwnerId = dto.OwnerId
        };

        await repository.AddAsync(entity);
        await outputPort.Handle(true);
    }
}

