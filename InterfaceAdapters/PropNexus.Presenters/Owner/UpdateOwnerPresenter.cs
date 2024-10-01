using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Owner.Update;

namespace PropNexus.Presenters.Owners;
public class UpdateOwnerPresenter : IUpdateOwnerOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}