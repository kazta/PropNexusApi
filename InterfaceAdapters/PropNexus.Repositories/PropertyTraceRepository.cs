using Microsoft.EntityFrameworkCore;
using PropNexus.Entities.Interfaces;
using PropNexus.Entities.Models;
using PropNexus.RepositoryEF.Contexts;

namespace PropNexus.Repositories;
public class PropertyTraceRepository(PropNexusDBContext context) : IPropertyTraceRepository
{
    public async Task AddAsync(PropertyTrace propertyTrace)
    {
        await context.PropertyTraces.AddAsync(propertyTrace);
        await context.SaveChangesAsync();
    }

    public async Task<PropertyTrace?> GetByIdAsync(long id)
    {
        return await context.PropertyTraces.FindAsync(id);
    }

    public async Task<IEnumerable<PropertyTrace>> GetAllAsync()
    {
        return await context.PropertyTraces.ToListAsync();
    }

    public async Task UpdateAsync(PropertyTrace propertyTrace)
    {
        context.PropertyTraces.Update(propertyTrace);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(PropertyTrace propertyTrace)
    {
        context.PropertyTraces.Remove(propertyTrace);
        await context.SaveChangesAsync();
    }
}