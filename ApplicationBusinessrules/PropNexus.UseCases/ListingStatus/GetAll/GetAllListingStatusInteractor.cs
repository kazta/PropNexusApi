using PropNexus.Dtos.ListingStatus;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.ListingStatus.GetAll;
public class GetAllListingStatusInteractor(IGetAllListingStatusOutputPort outputPort, IListingStatusRepository repository) : IGetAllListingStatusInputPort
{
    public async Task Handle()
    {
        var entities = await repository.GetAllAsync();
        var dtos = entities.Select(entity => new ListingStatusDto
        {
            Id = entity.Id,
            StatusName = entity.StatusName,
            Description = entity.Description
        });

        await outputPort.Handle(dtos);
    }
}