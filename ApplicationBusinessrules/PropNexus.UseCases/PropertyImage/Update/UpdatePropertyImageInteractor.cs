using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyImage.Update;
public class UpdatePropertyImageInteractor(IUpdatePropertyImageOutputPort outputPort, IPropertyImageRepository repository) : IUpdatePropertyImageInputPort
{
    public async Task Handle(PropertyImageDto dto)
    {
        var entity = await repository.GetByIdAsync(dto.Id);

        if (entity is null)
        {
            await outputPort.Handle(false);
            return;
        }

        entity.PropertyId = dto.PropertyId;
        entity.ImageUrl = dto.ImageUrl;
        entity.Description = dto.Description;

        await repository.UpdateAsync(entity);
        await outputPort.Handle(true);
    }
}