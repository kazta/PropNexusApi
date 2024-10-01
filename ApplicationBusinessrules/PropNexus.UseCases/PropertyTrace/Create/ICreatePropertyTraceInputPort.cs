using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.PropertyTrace.Create;

public interface ICreatePropertyTraceInputPort
{
    Task Handle(PropertyTraceDto dto);
}