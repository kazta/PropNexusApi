using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyTrace.Create;

namespace PropNexus.Presenters.PorpertyTrace;
public class CreatePropertyTracePresenter : ICreatePropertyTraceOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}