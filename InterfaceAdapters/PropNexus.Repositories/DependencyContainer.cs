using Microsoft.Extensions.DependencyInjection;
using PropNexus.Entities.Interfaces;

namespace PropNexus.Repositories;

public static class DependencyContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPropertyRepository, PropertyRepository>();
        services.AddScoped<IOwnerRepository, OwnerRepository>();
        services.AddScoped<IPropertyTraceRepository, PropertyTraceRepository>();
        return services;
    }
}