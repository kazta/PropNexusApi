using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.Property.Get;

public interface IGetPropertyOutputPort
{
    Task Handle(PropertyDto? dto);
}