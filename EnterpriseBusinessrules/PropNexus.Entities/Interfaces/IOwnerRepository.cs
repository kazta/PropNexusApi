using PropNexus.Entities.Models;

namespace PropNexus.Entities.Interfaces;

public interface IOwnerRepository
{
    Task AddAsync(Owner owner);
    Task DeleteAsync(Owner owner);
    Task<IEnumerable<Owner>> GetAllAsync();
    Task<Owner?> GetByIdAsync(long id);
    Task UpdateAsync(Owner owner);
}
