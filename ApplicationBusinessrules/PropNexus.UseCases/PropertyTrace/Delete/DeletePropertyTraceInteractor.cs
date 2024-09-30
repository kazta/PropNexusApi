using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyTrace.Delete;
public class DeletePropertyTraceInteractor(IDeletePropertyTraceOutputPort outputPort, IPropertyTraceRepository repository) : IDeletePropertyTraceInputPort
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