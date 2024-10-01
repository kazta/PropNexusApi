using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Property.Delete;

namespace PropNexus.Presenters.Property;

public class DeletePropertyPresenter : IDeletePropertyOutputPort, IPresenter<bool>
{
    public bool Content { get; private set; }

    public Task Handle(bool success)
    {
        Content = success;
        return Task.CompletedTask;
    }
}
