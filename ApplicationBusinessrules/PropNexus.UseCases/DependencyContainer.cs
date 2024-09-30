using Microsoft.Extensions.DependencyInjection;
using PropNexus.UseCases.Property.Create;
using PropNexus.UseCases.Property.Delete;
using PropNexus.UseCases.Property.Get;
using PropNexus.UseCases.Property.GetAll;
using PropNexus.UseCases.Property.Update;

namespace PropNexus.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        #region Property
        services.AddScoped<IGetAllPropertyInputPort, GetAllPropertyInteractor>();
        services.AddScoped<ICreatePropertyInputPort, CreatePropertyInteractor>();
        services.AddScoped<IUpdatePropertyInputPort, UpdatePropertyInteractor>();
        services.AddScoped<IGetPropertyInputPort, GetPropertyInteractor>();
        services.AddScoped<IDeletePropertyInputPort, DeletePropertyInteractor>();
        #endregion
        return services;
    }
}