using PropNexus.Dtos.ListingStatus;

namespace PropNexus.UseCases.ListingStatus.Get;

public interface IGetListingStatusOutputPort
{
    Task Handle(ListingStatusDto? dto);
}