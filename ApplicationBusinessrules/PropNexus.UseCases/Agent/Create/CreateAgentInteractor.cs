using PropNexus.Dtos.Agent;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Agent.Create;
public class CreateAgentInteractor(ICreateAgentOutputPort outputPort, IAgentRepository repository) : ICreateAgentInputPort
{
    public async Task Handle(AgentDto dto)
    {
        var entity = new Entities.Models.Agent
        {
            Id = dto.Id,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            Phone = dto.Phone
        };

        await repository.AddAsync(entity);
        await outputPort.Handle(true);
    }
}