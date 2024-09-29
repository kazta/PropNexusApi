using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Property.Create;

namespace PropNexus.Presenters.Property;

public class CreatePropertyPresenter : ICreatePropertyOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}
