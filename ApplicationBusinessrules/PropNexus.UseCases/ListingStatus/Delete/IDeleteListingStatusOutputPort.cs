
namespace PropNexus.UseCases.ListingStatus.Delete;

public interface IDeleteListingStatusOutputPort
{
    Task Handle(bool success);
}