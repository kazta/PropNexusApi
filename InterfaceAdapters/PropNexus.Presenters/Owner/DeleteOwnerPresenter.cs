using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Owner.Delete;

namespace PropNexus.Presenters.Owners;
public class DeleteOwnerPresenter : IDeleteOwnerOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}