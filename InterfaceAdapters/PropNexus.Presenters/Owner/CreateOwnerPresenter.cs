using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Owner.Create;

namespace PropNexus.Presenters.Owner;
public class CreateOwnerPresenter : ICreateOwnerOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}