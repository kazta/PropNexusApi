using Microsoft.EntityFrameworkCore;
using PropNexus.Entities.Interfaces;
using PropNexus.Entities.Models;
using PropNexus.RepositoryEF.Contexts;

namespace PropNexus.Repositories;
public class ListingStatusRepository(PropNexusDBContext context) : IListingStatusRepository
{
    public async Task AddAsync(ListingStatus listingStatus)
    {
        await context.ListingStatuses.AddAsync(listingStatus);
        await context.SaveChangesAsync();
    }

    public async Task<ListingStatus?> GetByIdAsync(long id)
    {
        return await context.ListingStatuses.FindAsync(id);
    }

    public async Task<IEnumerable<ListingStatus>> GetAllAsync()
    {
        return await context.ListingStatuses.ToListAsync();
    }

    public async Task UpdateAsync(ListingStatus listingStatus)
    {
        context.ListingStatuses.Update(listingStatus);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(ListingStatus listingStatus)
    {
        context.ListingStatuses.Remove(listingStatus);
        await context.SaveChangesAsync();
    }
}