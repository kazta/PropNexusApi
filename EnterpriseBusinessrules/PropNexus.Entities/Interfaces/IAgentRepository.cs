using PropNexus.Entities.Models;

namespace PropNexus.Entities.Interfaces;

public interface IAgentRepository
{
    Task AddAsync(Agent agent);
    Task DeleteAsync(Agent agent);
    Task<IEnumerable<Agent>> GetAllAsync();
    Task<Agent?> GetByIdAsync(long id);
    Task UpdateAsync(Agent agent);
}
