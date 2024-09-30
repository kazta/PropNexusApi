using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.ListingStatus.Delete;

public class DeleteListingStatusInteractor(IDeleteListingStatusOutputPort outputPort, IListingStatusRepository repository) : IDeleteListingStatusInputPort
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