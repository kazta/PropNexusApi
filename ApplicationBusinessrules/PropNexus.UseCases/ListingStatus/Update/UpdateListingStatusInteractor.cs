using PropNexus.Dtos.ListingStatus;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.ListingStatus.Update;
public class UpdateListingStatusInteractor(IUpdateListingStatusOutputPort outputPort, IListingStatusRepository repository) : IUpdateListingStatusInputPort
{
    public async Task Handle(ListingStatusDto dto)
    {
        var entity = await repository.GetByIdAsync(dto.Id);

        if (entity is null)
        {
            await outputPort.Handle(false);
            return;
        }

        entity.StatusName = dto.StatusName;
        entity.Description = dto.Description;

        await repository.UpdateAsync(entity);
        await outputPort.Handle(true);
    }
}
