using PropNexus.Dtos.Client;

namespace PropNexus.UseCases.Client.GetAll;

public interface IGetAllClientOutputPort
{
    Task Handle(IEnumerable<ClientDto> dtos);
}