using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyImage.Update;

namespace PropNexus.Presenters.PropertyImage;
public class UpdatePropertyImagePresenter : IUpdatePropertyImageOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}