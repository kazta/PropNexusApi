using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.PropertyImage.Update;

public interface IUpdatePropertyImageInputPort
{
    Task Handle(PropertyImageDto dto);
}