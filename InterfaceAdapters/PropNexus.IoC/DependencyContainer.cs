using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PropNexus.Presenters;
using PropNexus.Repositories;
using PropNexus.RepositoryEF.Contexts;
using PropNexus.UseCases;

namespace PropNexus.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddDbContext<PropNexusDBContext>(opt => opt.UseSqlServer("Server=34.27.248.253;Database=prop-nexus-db;User Id=app_user;Password=Qn1F0$SOX7*cy7M+;TrustServerCertificate=True;"));
        services.AddRepositories();
        services.AddUseCases();
        services.AddPresenters();
        return services;
    }
}