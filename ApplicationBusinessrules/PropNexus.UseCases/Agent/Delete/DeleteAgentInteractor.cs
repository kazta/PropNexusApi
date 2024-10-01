using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Agent.Delete;
public class DeleteAgentInteractor(IDeleteAgentOutputPort outputPort, IAgentRepository repository) : IDeleteAgentInputPort
{
    public async Task Handle(long id)
    {
        var entity = await repository.GetByIdAsync(id);

        if (entity is null)
        {
            await outputPort.Handle(false);
            return;
        }

        await repository.DeleteAsync(entity);
        await outputPort.Handle(true);
    }
}