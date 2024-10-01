using PropNexus.Dtos.Agent;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Agent.GetAll;
public class GetAllAgentInteractor(IGetAllAgentOutputPort outputPort, IAgentRepository repository) : IGetAllAgentInputPort
{
    public async Task Handle()
    {
        var entities = await repository.GetAllAsync();
        var dtos = entities.Select(entity => new AgentDto
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            Phone = entity.Phone
        });

        await outputPort.Handle(dtos);
    }
}