
namespace PropNexus.UseCases.PropertyImage.SendImage;

public interface ISendImageInputPort
{
    Task<bool> Handle(Stream stream, string filename);
}