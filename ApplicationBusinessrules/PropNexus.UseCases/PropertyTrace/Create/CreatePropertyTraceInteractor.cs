using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyTrace.Create;

public class CreatePropertyTraceInteractor(ICreatePropertyTraceOutputPort outputPort, IPropertyTraceRepository repository) : ICreatePropertyTraceInputPort
{
    public async Task Handle(PropertyTraceDto dto)
    {
        var entity = new Entities.Models.PropertyTrace
        {
            Id = dto.Id,
            PropertyId = dto.PropertyId,
            AgentId = dto.AgentId,
            ClientId = dto.ClientId,
            ListingDate = dto.ListingDate,
            StatusId = dto.StatusId
        };

        await repository.AddAsync(entity);
        await outputPort.Handle(true);
    }
}