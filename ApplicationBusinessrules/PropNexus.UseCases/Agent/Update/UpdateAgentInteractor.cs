using PropNexus.Dtos.Agent;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Agent.Update;
public class UpdateAgentInteractor(IUpdateAgentOutputPort outputPort, IAgentRepository repository) : IUpdateAgentInputPort
{
    public async Task Handle(AgentDto dto)
    {
        var entity = await repository.GetByIdAsync(dto.Id);

        if (entity is null)
        {
            await outputPort.Handle(false);
            return;
        }

        entity.FirstName = dto.FirstName;
        entity.LastName = dto.LastName;
        entity.Email = dto.Email;
        entity.Phone = dto.Phone;

        await repository.UpdateAsync(entity);
        await outputPort.Handle(true);
    }
}