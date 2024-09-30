using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyImage.GetAll;
public class GetAllPropertyImageInteractor(IGetAllPropertyImageOutputPort outputPort, IPropertyImageRepository repository) : IGetAllPropertyImageInputPort
{
    public async Task Handle()
    {
        var entities = await repository.GetAllAsync();
        var dtos = entities.Select(entity => new PropertyImageDto
        {
            Id = entity.Id,
            PropertyId = entity.PropertyId,
            ImageUrl = entity.ImageUrl,
            Description = entity.Description
        });

        await outputPort.Handle(dtos);
    }
}