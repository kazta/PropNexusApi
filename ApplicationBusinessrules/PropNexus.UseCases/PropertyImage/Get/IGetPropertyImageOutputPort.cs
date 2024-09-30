using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.PropertyImage.Get;

public interface IGetPropertyImageOutputPort
{
    Task Handle(PropertyImageDto? dto);
}