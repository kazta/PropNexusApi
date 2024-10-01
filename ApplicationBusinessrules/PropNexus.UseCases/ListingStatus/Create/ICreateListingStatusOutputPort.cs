
namespace PropNexus.UseCases.ListingStatus.Create;

public interface ICreateListingStatusOutputPort
{
    Task Handle(bool success);
}