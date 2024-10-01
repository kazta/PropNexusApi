using PropNexus.Dtos.Properties;

namespace PropNexus.UseCases.Property.GetAll;
public interface IGetAllPropertyInputPort
{
    Task Handle(PropertyRequest request);
}