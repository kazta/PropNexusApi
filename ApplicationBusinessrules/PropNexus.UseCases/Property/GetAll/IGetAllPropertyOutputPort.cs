using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.Property.GetAll;

public interface IGetAllPropertyOutputPort
{
    Task Handle(IEnumerable<PropertyDto> dtos);
}