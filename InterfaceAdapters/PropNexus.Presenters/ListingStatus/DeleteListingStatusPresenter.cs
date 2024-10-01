using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.ListingStatus.Delete;

namespace PropNexus.Presenters.ListingStatus;
public class DeleteListingStatusPresenter : IDeleteListingStatusOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}