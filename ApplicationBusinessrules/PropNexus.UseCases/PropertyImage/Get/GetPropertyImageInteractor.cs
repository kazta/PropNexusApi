using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyImage.Get;
public class GetPropertyImageInteractor(IGetPropertyImageOutputPort outputPort, IPropertyImageRepository repository) : IGetPropertyImageInputPort
{
    public async Task Handle(long id)
    {
        var entity = await repository.GetByIdAsync(id);

        if (entity is null)
        {
            await outputPort.Handle(null);
            return;
        }

        var dto = new PropertyImageDto
        {
            Id = entity.Id,
            PropertyId = entity.PropertyId,
            ImageUrl = entity.ImageUrl,
            Description = entity.Description
        };

        await outputPort.Handle(dto);
    }
}