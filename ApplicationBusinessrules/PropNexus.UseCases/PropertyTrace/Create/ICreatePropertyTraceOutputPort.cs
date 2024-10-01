
namespace PropNexus.UseCases.PropertyTrace.Create;

public interface ICreatePropertyTraceOutputPort
{
    Task Handle(bool success);
}