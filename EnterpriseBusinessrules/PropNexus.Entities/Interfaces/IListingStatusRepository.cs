using PropNexus.Entities.Models;

namespace PropNexus.Entities.Interfaces;

public interface IListingStatusRepository
{
    Task AddAsync(ListingStatus listingStatus);
    Task DeleteAsync(ListingStatus listingStatus);
    Task<IEnumerable<ListingStatus>> GetAllAsync();
    Task<ListingStatus?> GetByIdAsync(long id);
    Task UpdateAsync(ListingStatus listingStatus);
}
