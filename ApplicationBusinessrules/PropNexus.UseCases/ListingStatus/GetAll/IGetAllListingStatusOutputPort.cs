using PropNexus.Dtos.ListingStatus;

namespace PropNexus.UseCases.ListingStatus.GetAll;

public interface IGetAllListingStatusOutputPort
{
    Task Handle(IEnumerable<ListingStatusDto> dtos);
}