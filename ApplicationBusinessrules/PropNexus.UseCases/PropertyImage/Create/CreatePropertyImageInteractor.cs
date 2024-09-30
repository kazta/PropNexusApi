using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyImage.Create;
public class CreatePropertyImageInteractor(ICreatePropertyImageOutputPort outputPort, IPropertyImageRepository repository) : ICreatePropertyImageInputPort
{
    public async Task Handle(PropertyImageDto dto)
    {
        var entity = new Entities.Models.PropertyImage
        {
            Id = dto.Id,
            PropertyId = dto.PropertyId,
            ImageUrl = dto.ImageUrl,
            Description = dto.Description
        };

        await repository.AddAsync(entity);
        await outputPort.Handle(true);
    }
}