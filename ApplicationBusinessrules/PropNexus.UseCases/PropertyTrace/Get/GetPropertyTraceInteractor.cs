using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyTrace.Get;

public class GetPropertyTraceInteractor(IGetPropertyTraceOutputPort outputPort, IPropertyTraceRepository repository) : IGetPropertyTraceInputPort
{
    public async Task Handle(long id)
    {
        var entity = await repository.GetByIdAsync(id);

        if (entity is null)
        {
            await outputPort.Handle(null);
            return;
        }

        var dto = new PropertyTraceDto
        {
            Id = entity.Id,
            PropertyId = entity.PropertyId,
            AgentId = entity.AgentId,
            ClientId = entity.ClientId,
            ListingDate = entity.ListingDate,
            StatusId = entity.StatusId
        };

        await outputPort.Handle(dto);
    }
}
