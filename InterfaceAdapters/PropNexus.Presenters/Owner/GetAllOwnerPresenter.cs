using PropNexus.Dtos.Owners;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Owner.GetAll;

namespace PropNexus.Presenters.Owner;

public class GetAllOwnerPresenter : IGetAllOwnerOutputPort, IPresenter<IEnumerable<OwnerDto>>
{
    public IEnumerable<OwnerDto> Content { get; private set; } = Enumerable.Empty<OwnerDto>();

    public Task Handle(IEnumerable<OwnerDto> dtos)
    {
        Content = dtos;
        return Task.CompletedTask;
    }
}
