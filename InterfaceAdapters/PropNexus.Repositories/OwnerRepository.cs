using Microsoft.EntityFrameworkCore;
using PropNexus.Entities.Interfaces;
using PropNexus.Entities.Models;
using PropNexus.RepositoryEF.Contexts;

namespace PropNexus.Repositories;

public class OwnerRepository(PropNexusDBContext context) : IOwnerRepository
{
    public async Task AddAsync(Owner owner)
    {
        await context.Owners.AddAsync(owner);
        await context.SaveChangesAsync();
    }

    public async Task<Owner?> GetByIdAsync(long id)
    {
        return await context.Owners.FindAsync(id);
    }

    public async Task<IEnumerable<Owner>> GetAllAsync()
    {
        return await context.Owners.ToListAsync();
    }

    public async Task UpdateAsync(Owner owner)
    {
        context.Owners.Update(owner);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Owner owner)
    {
        context.Owners.Remove(owner);
        await context.SaveChangesAsync();
    }
}
