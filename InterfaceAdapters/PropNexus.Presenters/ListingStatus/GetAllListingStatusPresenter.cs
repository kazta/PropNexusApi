using PropNexus.Dtos.ListingStatus;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.ListingStatus.GetAll;

namespace PropNexus.Presenters.ListingStatus;
public class GetAllListingStatusPresenter : IGetAllListingStatusOutputPort, IPresenter<IEnumerable<ListingStatusDto>>
{
    public IEnumerable<ListingStatusDto> Content { get; private set; } = Enumerable.Empty<ListingStatusDto>();

    public Task Handle(IEnumerable<ListingStatusDto> dtos)
    {
        Content = dtos;
        return Task.CompletedTask;
    }
}