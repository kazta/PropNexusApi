using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyTrace.GetAll;
public class GetAllPropertyTraceInteractor(IGetAllPropertyTraceOutputPort outputPort, IPropertyTraceRepository repository) : IGetAllPropertyTraceInputPort
{
    public async Task Handle()
    {
        var entities = await repository.GetAllAsync();
        var dtos = entities.Select(entity => new PropertyTraceDto
        {
            Id = entity.Id,
            PropertyId = entity.PropertyId,
            AgentId = entity.AgentId,
            ClientId = entity.ClientId,
            ListingDate = entity.ListingDate,
            StatusId = entity.StatusId
        });

        await outputPort.Handle(dtos);
    }
}