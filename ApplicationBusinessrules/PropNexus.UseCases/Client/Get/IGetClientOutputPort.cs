using PropNexus.Dtos.Client;

namespace PropNexus.UseCases.Client.Get;

public interface IGetClientOutputPort
{
    Task Handle(ClientDto? dto);
}