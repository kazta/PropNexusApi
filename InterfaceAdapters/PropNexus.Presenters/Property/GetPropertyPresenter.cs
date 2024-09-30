using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Property.Get;

namespace PropNexus.Presenters.Property;

public class GetPropertyPresenter : IGetPropertyOutputPort, IPresenter<PropertyDto?>
{
    public PropertyDto? Content { get; private set; }

    public Task Handle(PropertyDto? dto)
    {
        Content = dto;
        return Task.CompletedTask;
    }
}
