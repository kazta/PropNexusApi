using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyTrace.GetAll;

namespace PropNexus.Presenters.PorpertyTrace;
public class GetAllPropertyTracePresenter : IGetAllPropertyTraceOutputPort, IPresenter<IEnumerable<PropertyTraceDto>>
{
    public IEnumerable<PropertyTraceDto> Content { get; private set; } = Enumerable.Empty<PropertyTraceDto>();

    public Task Handle(IEnumerable<PropertyTraceDto> dtos)
    {
        Content = dtos;
        return Task.CompletedTask;
    }
}