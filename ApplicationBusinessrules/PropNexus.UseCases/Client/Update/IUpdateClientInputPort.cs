using PropNexus.Dtos.Client;

namespace PropNexus.UseCases.Client.Update;

public interface IUpdateClientInputPort
{
    Task Handle(ClientDto dto);
}