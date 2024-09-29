using Microsoft.Extensions.DependencyInjection;
using PropNexus.UseCases.Property.Create;
using PropNexus.UseCases.Property.GetAll;

namespace PropNexus.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IGetAllPropertyInputPort, GetAllPropertyInteractor>();
        services.AddScoped<ICreatePropertyInputPort, CreatePropertyInteractor>();
        return services;
    }
}