using Microsoft.Extensions.DependencyInjection;
using PropNexus.Presenters.Owner;
using PropNexus.Presenters.Owners;
using PropNexus.Presenters.Property;
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

namespace PropNexus.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddPresenters(this IServiceCollection services)
    {
        #region Property
        services.AddScoped<ICreatePropertyOutputPort, CreatePropertyPresenter>();
        services.AddScoped<IGetPropertyOutputPort, GetPropertyPresenter>();
        services.AddScoped<IUpdatePropertyOutputPort, UpdatePropertyPresenter>();
        services.AddScoped<IDeletePropertyOutputPort, DeletePropertyPresenter>();
        services.AddScoped<IGetAllPropertyOutputPort, GetAllPropertyPresenter>();
        #endregion
        #region Owner
        services.AddScoped<ICreateOwnerOutputPort, CreateOwnerPresenter>();
        services.AddScoped<IGetOwnerOutputPort, GetOwnerPresenter>();
        services.AddScoped<IUpdateOwnerOutputPort, UpdateOwnerPresenter>();
        services.AddScoped<IDeleteOwnerOutputPort, DeleteOwnerPresenter>();
        services.AddScoped<IGetAllOwnerOutputPort, GetAllOwnerPresenter>();
        #endregion
        return services;
    }
}