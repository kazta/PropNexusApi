using PropNexus.Entities.Interfaces;

namespace PropNexus.UseCases.PropertyImage.SendImage;

internal class SendImageInteractor(IProcessImage processImage): ISendImageInputPort
{
    public async Task<bool> Handle(Stream stream, string filename)
    {
        return await processImage.Process(stream, filename);
    }
}
