using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using PropNexus.Entities.Interfaces;

namespace PorpNexus.RepositoryGC.Storage;

public class SendImage : IProcessImage
{
    private readonly string path = "../../InterfaceAdapters/PorpNexus.RepositoryGC/utils/monk3y-bf4f01d3275b.json";
    public async Task<bool> Process(Stream stream, string filename)
    {

        var storage = await StorageClient.CreateAsync(LoadCredentials());
        var response = await storage.UploadObjectAsync("prop-nexus-bucket", filename, null, stream);
        if (response != null)
        {
            return false;
        }
        return true;
    }

    internal GoogleCredential LoadCredentials()
    {
        if (!Path.Exists(path))
            throw new Exception($"No se encontró archivo {path}");

        return GoogleCredential.FromFile(path);
    }
}
