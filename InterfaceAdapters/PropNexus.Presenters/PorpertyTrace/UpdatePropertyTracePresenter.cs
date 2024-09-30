using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyTrace.Update;

namespace PropNexus.Presenters.PorpertyTrace;
public class UpdatePropertyTracePresenter : IUpdatePropertyTraceOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}