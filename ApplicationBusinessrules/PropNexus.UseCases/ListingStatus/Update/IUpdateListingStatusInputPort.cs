using PropNexus.Dtos.ListingStatus;

namespace PropNexus.UseCases.ListingStatus.Update;

public interface IUpdateListingStatusInputPort
{
    Task Handle(ListingStatusDto dto);
}