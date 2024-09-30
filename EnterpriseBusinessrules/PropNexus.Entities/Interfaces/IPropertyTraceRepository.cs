using PropNexus.Entities.Models;

namespace PropNexus.Entities.Interfaces;

public interface IPropertyTraceRepository
{
    Task AddAsync(PropertyTrace propertyTrace);
    Task DeleteAsync(PropertyTrace propertyTrace);
    Task<IEnumerable<PropertyTrace>> GetAllAsync();
    Task<PropertyTrace?> GetByIdAsync(long id);
    Task UpdateAsync(PropertyTrace propertyTrace);
}
