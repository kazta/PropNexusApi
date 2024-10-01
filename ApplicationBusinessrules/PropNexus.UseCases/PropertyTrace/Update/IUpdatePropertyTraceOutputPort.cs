
namespace PropNexus.UseCases.PropertyTrace.Update;

public interface IUpdatePropertyTraceOutputPort
{
    Task Handle(bool success);
}