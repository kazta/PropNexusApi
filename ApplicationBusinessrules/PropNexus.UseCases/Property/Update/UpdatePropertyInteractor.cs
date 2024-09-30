using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Property.Update;
public class UpdatePropertyInteractor(IUpdatePropertyOutputPort outputPort, IPropertyRepository repository) : IUpdatePropertyInputPort
{
    public async Task Handle(PropertyDto dto)
    {
        var entity = await repository.GetByIdAsync(dto.Id);

        if (entity is null)
        {
            await outputPort.Handle(false);
            return;
        }

        entity.Address = dto.Address;
        entity.City = dto.City;
        entity.State = dto.State;
        entity.ZipCode = dto.ZipCode;
        entity.Price = dto.Price;
        entity.Bedrooms = dto.Bedrooms;
        entity.Bathrooms = dto.Bathrooms;
        entity.SquareFeet = dto.SquareFeet;
        entity.PropertyType = dto.PropertyType;
        entity.Description = dto.Description;
        entity.OwnerId = dto.OwnerId;

        await repository.UpdateAsync(entity);
        await outputPort.Handle(true);
    }
}