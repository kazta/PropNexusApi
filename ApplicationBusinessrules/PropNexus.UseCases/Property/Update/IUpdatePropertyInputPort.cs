using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.Property.Update;

public interface IUpdatePropertyInputPort
{
    Task Handle(PropertyDto dto);
}