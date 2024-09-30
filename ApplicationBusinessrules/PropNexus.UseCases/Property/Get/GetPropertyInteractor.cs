using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Property.Get;

public class GetPropertyInteractor(IGetPropertyOutputPort outputPort, IPropertyRepository repository) : IGetPropertyInputPort
{
    public async Task Handle(long id)
    {
        var entity = await repository.GetByIdAsync(id);

        if (entity is null)
        {
            await outputPort.Handle(null);
            return;
        }

        var dto = new PropertyDto
        {
            Id = entity.Id,
            Address = entity.Address,
            City = entity.City,
            State = entity.State,
            ZipCode = entity.ZipCode,
            Price = entity.Price,
            Bedrooms = entity.Bedrooms,
            Bathrooms = entity.Bathrooms,
            SquareFeet = entity.SquareFeet,
            PropertyType = entity.PropertyType,
            Description = entity.Description,
            OwnerId = entity.OwnerId
        };

        await outputPort.Handle(dto);
    }
}
