using PropNexus.Dtos.ListingStatus;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.ListingStatus.Get;

public class GetListingStatusInteractor(IGetListingStatusOutputPort outputPort, IListingStatusRepository repository) : IGetListingStatusInputPort
{
    public async Task Handle(long id)
    {
        var entity = await repository.GetByIdAsync(id);

        if (entity is null)
        {
            await outputPort.Handle(null);
            return;
        }

        var dto = new ListingStatusDto
        {
            Id = entity.Id,
            StatusName = entity.StatusName,
            Description = entity.Description
        };

        await outputPort.Handle(dto);
    }
}
