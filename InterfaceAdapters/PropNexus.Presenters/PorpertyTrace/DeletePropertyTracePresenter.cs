using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyTrace.Delete;

namespace PropNexus.Presenters.PorpertyTrace;
public class DeletePropertyTracePresenter : IDeletePropertyTraceOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}