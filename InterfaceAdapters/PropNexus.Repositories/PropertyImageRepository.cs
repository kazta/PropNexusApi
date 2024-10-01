using Microsoft.EntityFrameworkCore;
using PropNexus.Entities.Interfaces;
using PropNexus.Entities.Models;
using PropNexus.RepositoryEF.Contexts;

namespace PropNexus.Repositories;
public class PropertyImageRepository(PropNexusDBContext context) : IPropertyImageRepository
{
    public async Task AddAsync(PropertyImage propertyImage)
    {
        await context.PropertyImages.AddAsync(propertyImage);
        await context.SaveChangesAsync();
    }

    public async Task<PropertyImage?> GetByIdAsync(long id)
    {
        return await context.PropertyImages.FindAsync(id);
    }

    public async Task<IEnumerable<PropertyImage>> GetAllAsync()
    {
        return await context.PropertyImages.ToListAsync();
    }

    public async Task UpdateAsync(PropertyImage propertyImage)
    {
        context.PropertyImages.Update(propertyImage);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(PropertyImage propertyImage)
    {
        context.PropertyImages.Remove(propertyImage);
        await context.SaveChangesAsync();
    }
}