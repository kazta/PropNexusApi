using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.Property.Delete;
public class DeletePropertyInteractor(IDeletePropertyOutputPort outputPort, IPropertyRepository repository) : IDeletePropertyInputPort
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
