
namespace PropNexus.UseCases.ListingStatus.Update;

public interface IUpdateListingStatusOutputPort
{
    Task Handle(bool success);
}