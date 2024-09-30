using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyTrace.Get;

namespace PropNexus.Presenters.PorpertyTrace;

public class GetPropertyTracePresenter : IGetPropertyTraceOutputPort, IPresenter<PropertyTraceDto?>
{
    public PropertyTraceDto? Content { get; private set; }

    public Task Handle(PropertyTraceDto? dto)
    {
        Content = dto;
        return Task.CompletedTask;
    }
}
