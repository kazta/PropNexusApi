using Microsoft.Extensions.DependencyInjection;
using PropNexus.Entities.Interfaces;

namespace PropNexus.Repositories;

public static class DependencyContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPropertyRepository, PropertyRepository>();
        return services;
    }
}