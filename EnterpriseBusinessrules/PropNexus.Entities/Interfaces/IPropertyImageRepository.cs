using PropNexus.Entities.Models;

namespace PropNexus.Entities.Interfaces;

public interface IPropertyImageRepository
{
    Task AddAsync(PropertyImage propertyImage);
    Task DeleteAsync(PropertyImage propertyImage);
    Task<IEnumerable<PropertyImage>> GetAllAsync();
    Task<PropertyImage?> GetByIdAsync(long id);
    Task UpdateAsync(PropertyImage propertyImage);
}
