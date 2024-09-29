using Microsoft.Extensions.DependencyInjection;
using PropNexus.Presenters.Property;
using PropNexus.UseCases.Property.Create;
using PropNexus.UseCases.Property.GetAll;

namespace PropNexus.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddPresenters(this IServiceCollection services)
    {
        services.AddScoped<IGetAllPropertyOutputPort, GetAllPropertyPresenter>();
        services.AddScoped<ICreatePropertyOutputPort, CreatePropertyPresenter>();
        return services;
    }
}