using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyImage.Create;

namespace PropNexus.Presenters.PropertyImage;
public class CreatePropertyImagePresenter : ICreatePropertyImageOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}