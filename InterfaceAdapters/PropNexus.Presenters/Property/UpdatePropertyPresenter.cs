using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Property.Update;

namespace PropNexus.Presenters.Property;

public class UpdatePropertyPresenter : IUpdatePropertyOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}
