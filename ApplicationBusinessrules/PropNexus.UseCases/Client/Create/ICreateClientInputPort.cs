using PropNexus.Dtos.Client;

namespace PropNexus.UseCases.Client.Create;

public interface ICreateClientInputPort
{
    Task Handle(ClientDto dto);
}