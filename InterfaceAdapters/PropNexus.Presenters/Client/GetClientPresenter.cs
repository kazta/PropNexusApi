using PropNexus.Dtos.Client;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Client.Get;

namespace PropNexus.Presenters.Client;
public class GetClientPresenter : IGetClientOutputPort, IPresenter<ClientDto?>
{
    public ClientDto? Content { get; private set; }

    public Task Handle(ClientDto? dto)
    {
        Content = dto;
        return Task.CompletedTask;
    }
}