using PropNexus.Dtos.Client;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Client.GetAll;

namespace PropNexus.Presenters.Client;
public class GetAllClientPresenter : IGetAllClientOutputPort, IPresenter<IEnumerable<ClientDto>>
{
    public IEnumerable<ClientDto> Content { get; private set; } = Enumerable.Empty<ClientDto>();

    public Task Handle(IEnumerable<ClientDto> dtos)
    {
        Content = dtos;
        return Task.CompletedTask;
    }
}