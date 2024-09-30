using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.PropertyTrace.Update;

public interface IUpdatePropertyTraceInputPort
{
    Task Handle(PropertyTraceDto dto);
}