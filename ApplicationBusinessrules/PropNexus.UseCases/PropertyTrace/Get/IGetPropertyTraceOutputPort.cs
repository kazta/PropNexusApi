using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.PropertyTrace.Get;

public interface IGetPropertyTraceOutputPort
{
    Task Handle(PropertyTraceDto? dto);
}