using PropNexus.Dtos.Agent;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Agent.Get;
public class GetAgentInteractor(IGetAgentOutputPort outputPort, IAgentRepository repository) : IGetAgentInputPort
{
    public async Task Handle(long id)
    {
        var entity = await repository.GetByIdAsync(id);

        if (entity is null)
        {
            await outputPort.Handle(null);
            return;
        }

        var dto = new AgentDto
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            Phone = entity.Phone
        };

        await outputPort.Handle(dto);
    }
}