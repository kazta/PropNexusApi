using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyImage.GetAll;

namespace PropNexus.Presenters.PropertyImage;

public class GetAllPropertyImagePresenter : IGetAllPropertyImageOutputPort, IPresenter<IEnumerable<PropertyImageDto>>
{
    public IEnumerable<PropertyImageDto> Content { get; private set; } = Enumerable.Empty<PropertyImageDto>();

    public Task Handle(IEnumerable<PropertyImageDto> dtos)
    {
        Content = dtos;
        return Task.CompletedTask;
    }
}
