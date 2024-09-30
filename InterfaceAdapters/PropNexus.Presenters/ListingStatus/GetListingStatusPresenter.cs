using PropNexus.Dtos.ListingStatus;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.ListingStatus.Get;

namespace PropNexus.Presenters.ListingStatus;
public class GetListingStatusPresenter : IGetListingStatusOutputPort, IPresenter<ListingStatusDto?>
{
    public ListingStatusDto? Content { get; private set; }

    public Task Handle(ListingStatusDto? dto)
    {
        Content = dto;
        return Task.CompletedTask;
    }
}