
namespace PropNexus.UseCases.PropertyTrace.Delete;

public interface IDeletePropertyTraceInputPort
{
    Task Handle(long id);
}