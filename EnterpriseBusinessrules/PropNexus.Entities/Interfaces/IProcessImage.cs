namespace PropNexus.Entities.Interfaces;

public interface IProcessImage
{
    Task<bool> Process(Stream stream, string filename);
}
