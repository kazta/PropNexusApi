using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.PropertyImage.Create;

public interface ICreatePropertyImageInputPort
{
    Task Handle(PropertyImageDto dto);
}