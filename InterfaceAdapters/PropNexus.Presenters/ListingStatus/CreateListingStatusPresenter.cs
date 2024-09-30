using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.ListingStatus.Create;

namespace PropNexus.Presenters.ListingStatus;
public class CreateListingStatusPresenter : ICreateListingStatusOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}