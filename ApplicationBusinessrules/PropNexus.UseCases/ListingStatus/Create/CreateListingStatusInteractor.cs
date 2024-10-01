using PropNexus.Dtos.ListingStatus;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.ListingStatus.Create;
public class CreateListingStatusInteractor(ICreateListingStatusOutputPort outputPort, IListingStatusRepository repository) : ICreateListingStatusInputPort
{
    public async Task Handle(ListingStatusDto dto)
    {
        var entity = new Entities.Models.ListingStatus
        {
            Id = dto.Id,
            StatusName = dto.StatusName,
            Description = dto.Description
        };

        await repository.AddAsync(entity);
        await outputPort.Handle(true);
    }
}