using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.PropertyImage.GetAll;

public interface IGetAllPropertyImageOutputPort
{
    Task Handle(IEnumerable<PropertyImageDto> dtos);
}