using Microsoft.EntityFrameworkCore;
using PropNexus.Entities.Interfaces;
using PropNexus.Entities.Models;
using PropNexus.RepositoryEF.Contexts;

namespace PropNexus.Repositories;

public class PropertyRepository(PropNexusDBContext _context) : IPropertyRepository
{
    public async Task AddAsync(Property property)
    {
        await _context.Properties.AddAsync(property);
        await _context.SaveChangesAsync();
    }

    public async Task<Property?> GetByIdAsync(long id)
    {
        return await _context.Properties.FindAsync(id);
    }

    public async Task<IEnumerable<Property>> GetAllAsync(ICriteria<Property> criteria)
    {
        var query =_context.Properties.AsQueryable();
        return await criteria.Apply(query).ToListAsync();
    }

    public async Task UpdateAsync(Property property)
    {
        _context.Properties.Update(property);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Property property)
    {
        _context.Properties.Remove(property);
        await _context.SaveChangesAsync();
    }
}
