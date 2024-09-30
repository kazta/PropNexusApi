using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyImage.Get;

namespace PropNexus.Presenters.PropertyImage;
public class GetPropertyImagePresenter : IGetPropertyImageOutputPort, IPresenter<PropertyImageDto?>
{
    public PropertyImageDto? Content { get; private set; }

    public Task Handle(PropertyImageDto? dto)
    {
        Content = dto;
        return Task.CompletedTask;
    }
}