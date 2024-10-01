using Microsoft.EntityFrameworkCore;
using PropNexus.Entities.Interfaces;
using PropNexus.Entities.Models;
using PropNexus.RepositoryEF.Contexts;

namespace PropNexus.Repositories;

public class ClientRepository(PropNexusDBContext context) : IClientRepository
{
    public async Task AddAsync(Client client)
    {
        await context.Clients.AddAsync(client);
        await context.SaveChangesAsync();
    }

    public async Task<Client?> GetByIdAsync(long id)
    {
        return await context.Clients.FindAsync(id);
    }

    public async Task<IEnumerable<Client>> GetAllAsync()
    {
        return await context.Clients.ToListAsync();
    }

    public async Task UpdateAsync(Client client)
    {
        context.Clients.Update(client);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Client client)
    {
        context.Clients.Remove(client);
        await context.SaveChangesAsync();
    }
}
