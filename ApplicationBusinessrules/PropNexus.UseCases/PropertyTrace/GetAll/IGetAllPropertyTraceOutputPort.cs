using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.PropertyTrace.GetAll;

public interface IGetAllPropertyTraceOutputPort
{
    Task Handle(IEnumerable<PropertyTraceDto> dtos);
}