using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Owner.Delete;

public class DeleteOwnerInteractor(IDeleteOwnerOutputPort outputPort, IOwnerRepository repository) : IDeleteOwnerInputPort
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
