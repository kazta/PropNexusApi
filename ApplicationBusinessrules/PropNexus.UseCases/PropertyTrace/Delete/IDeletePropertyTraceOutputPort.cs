
namespace PropNexus.UseCases.PropertyTrace.Delete;

public interface IDeletePropertyTraceOutputPort
{
    Task Handle(bool success);
}