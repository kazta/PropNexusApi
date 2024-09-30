using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyImage.Delete;

public class DeletePropertyImageInteractor(IDeletePropertyImageOutputPort outputPort, IPropertyImageRepository repository) : IDeletePropertyImageInputPort
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