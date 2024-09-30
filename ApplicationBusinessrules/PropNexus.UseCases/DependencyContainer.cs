using Microsoft.Extensions.DependencyInjection;
using PropNexus.UseCases.Owner.Create;
using PropNexus.UseCases.Owner.Delete;
using PropNexus.UseCases.Owner.Get;
using PropNexus.UseCases.Owner.GetAll;
using PropNexus.UseCases.Owner.Update;
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
        #region Owner
        services.AddScoped<ICreateOwnerInputPort, CreateOwnerInteractor>();
        services.AddScoped<IGetOwnerInputPort, GetOwnerInteractor>();
        services.AddScoped<IUpdateOwnerInputPort, UpdateOwnerInteractor>();
        services.AddScoped<IDeleteOwnerInputPort, DeleteOwnerInteractor>();
        services.AddScoped<IGetAllOwnerInputPort, GetAllOwnerInteractor>();
        #endregion
        return services;
    }
}