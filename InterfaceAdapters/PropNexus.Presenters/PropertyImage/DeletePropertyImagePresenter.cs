using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyImage.Delete;

namespace PropNexus.Presenters.PropertyImage;

public class DeletePropertyImagePresenter : IDeletePropertyImageOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}