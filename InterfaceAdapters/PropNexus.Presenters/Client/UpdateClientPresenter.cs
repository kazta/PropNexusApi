using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Client.Update;

namespace PropNexus.Presenters.Client;
public class UpdateClientPresenter : IUpdateClientOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}
