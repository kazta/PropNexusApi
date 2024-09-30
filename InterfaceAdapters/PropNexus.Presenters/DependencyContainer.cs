using Microsoft.Extensions.DependencyInjection;
using PropNexus.Presenters.Property;
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
        return services;
    }
}