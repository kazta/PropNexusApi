
namespace PropNexus.UseCases.ListingStatus.Delete;

public interface IDeleteListingStatusInputPort
{
    Task Handle(long id);
}