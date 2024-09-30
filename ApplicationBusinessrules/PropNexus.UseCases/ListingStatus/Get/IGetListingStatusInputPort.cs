
namespace PropNexus.UseCases.ListingStatus.Get;

public interface IGetListingStatusInputPort
{
    Task Handle(long id);
}