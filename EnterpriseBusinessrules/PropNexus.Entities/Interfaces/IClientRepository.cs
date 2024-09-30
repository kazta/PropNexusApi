using PropNexus.Entities.Models;

namespace PropNexus.Entities.Interfaces;

public interface IClientRepository
{
    Task AddAsync(Client client);
    Task DeleteAsync(Client client);
    Task<IEnumerable<Client>> GetAllAsync();
    Task<Client?> GetByIdAsync(long id);
    Task UpdateAsync(Client client);
}
