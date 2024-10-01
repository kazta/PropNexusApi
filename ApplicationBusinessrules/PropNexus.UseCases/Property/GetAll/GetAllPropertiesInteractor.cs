using PropNexus.Criterias;
using PropNexus.Criterias.Property;
using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using Model = PropNexus.Entities.Models.Property;

namespace PropNexus.UseCases.Property.GetAll;

public class GetAllPropertyInteractor(IGetAllPropertyOutputPort outputPort, IPropertyRepository repository) : IGetAllPropertyInputPort
{
    public async Task Handle(PropertyRequest request)
    {
        var criteria = new CriteriaList<Model>(new PropertyBedroomsCriteria(request.Bedrooms));
        var entities = await repository.GetAllAsync(criteria);
        var dtos = entities.Select(entity => new PropertyDto
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
        });

        await outputPort.Handle(dtos);
    }
}
