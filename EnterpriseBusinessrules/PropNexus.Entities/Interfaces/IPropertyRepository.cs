using PropNexus.Entities.Models;

namespace PropNexus.Entities.Interfaces;

public interface IPropertyRepository
{
    Task AddAsync(Property property);
    Task<Property?> GetByIdAsync(long id);
    Task<IEnumerable<Property>> GetAllAsync();
    Task UpdateAsync(Property property);
    Task DeleteAsync(Property property);
}