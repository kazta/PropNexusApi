using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Client.Create;

namespace PropNexus.Presenters.Client;
public class CreateClientPresenter : ICreateClientOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}