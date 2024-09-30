using Microsoft.EntityFrameworkCore;
using PropNexus.Entities.Interfaces;
using PropNexus.Entities.Models;
using PropNexus.RepositoryEF.Contexts;

namespace PropNexus.Repositories;
public class AgentRepository(PropNexusDBContext context) : IAgentRepository
{
    public async Task AddAsync(Agent agent)
    {
        await context.Agents.AddAsync(agent);
        await context.SaveChangesAsync();
    }

    public async Task<Agent?> GetByIdAsync(long id)
    {
        return await context.Agents.FindAsync(id);
    }

    public async Task<IEnumerable<Agent>> GetAllAsync()
    {
        return await context.Agents.ToListAsync();
    }

    public async Task UpdateAsync(Agent agent)
    {
        context.Agents.Update(agent);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Agent agent)
    {
        context.Agents.Remove(agent);
        await context.SaveChangesAsync();
    }
}