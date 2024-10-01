
namespace PropNexus.UseCases.PropertyTrace.Get;

public interface IGetPropertyTraceInputPort
{
    Task Handle(long id);
}