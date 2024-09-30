using PropNexus.Dtos.Owners;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Owner.Get;

namespace PropNexus.Presenters.Owners;

public class GetOwnerPresenter : IGetOwnerOutputPort, IPresenter<OwnerDto?>
{
    public OwnerDto? Content { get; private set; }

    public Task Handle(OwnerDto? dto)
    {
        Content = dto;
        return Task.CompletedTask;
    }
}
