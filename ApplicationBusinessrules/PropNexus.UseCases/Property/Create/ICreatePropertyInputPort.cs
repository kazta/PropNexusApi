using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.Property.Create;
public interface ICreatePropertyInputPort
{
    Task Handle(PropertyDto dto);
}
