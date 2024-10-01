using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Property.GetAll;

namespace PropNexus.Presenters.Property;

public class GetAllPropertyPresenter : IGetAllPropertyOutputPort, IPresenter<IEnumerable<PropertyDto>>
{
    public IEnumerable<PropertyDto> Content { get; private set; } = Enumerable.Empty<PropertyDto>();

    public Task Handle(IEnumerable<PropertyDto> dtos)
    {
        Content = dtos;
        return Task.CompletedTask;
    }
}
