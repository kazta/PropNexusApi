using PropNexus.Dtos.ListingStatus;

namespace PropNexus.UseCases.ListingStatus.Create;

public interface ICreateListingStatusInputPort
{
    Task Handle(ListingStatusDto dto);
}