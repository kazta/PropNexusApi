using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.ListingStatus.Update;

namespace PropNexus.Presenters.ListingStatus;
public class UpdateListingStatusPresenter : IUpdateListingStatusOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}