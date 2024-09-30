using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyTrace.Update;

public class UpdatePropertyTraceInteractor(IUpdatePropertyTraceOutputPort outputPort, IPropertyTraceRepository repository) : IUpdatePropertyTraceInputPort
{
    public async Task Handle(PropertyTraceDto dto)
    {
        var entity = await repository.GetByIdAsync(dto.Id);

        if (entity is null)
        {
            await outputPort.Handle(false);
            return;
        }

        entity.PropertyId = dto.PropertyId;
        entity.AgentId = dto.AgentId;
        entity.ClientId = dto.ClientId;
        entity.ListingDate = dto.ListingDate;
        entity.StatusId = dto.StatusId;

        await repository.UpdateAsync(entity);
        await outputPort.Handle(true);
    }
}
