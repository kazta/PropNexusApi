using Microsoft.Extensions.DependencyInjection;
using PropNexus.UseCases.Agent.Create;
using PropNexus.UseCases.Agent.Delete;
using PropNexus.UseCases.Agent.Get;
using PropNexus.UseCases.Agent.GetAll;
using PropNexus.UseCases.Agent.Update;
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
using PropNexus.UseCases.PropertyTrace.Create;
using PropNexus.UseCases.PropertyTrace.Delete;
using PropNexus.UseCases.PropertyTrace.Get;
using PropNexus.UseCases.PropertyTrace.GetAll;
using PropNexus.UseCases.PropertyTrace.Update;

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
        #region PropertyTrace
        services.AddScoped<ICreatePropertyTraceInputPort, CreatePropertyTraceInteractor>();
        services.AddScoped<IGetPropertyTraceInputPort, GetPropertyTraceInteractor>();
        services.AddScoped<IUpdatePropertyTraceInputPort, UpdatePropertyTraceInteractor>();
        services.AddScoped<IDeletePropertyTraceInputPort, DeletePropertyTraceInteractor>();
        services.AddScoped<IGetAllPropertyTraceInputPort, GetAllPropertyTraceInteractor>();
        #endregion
        #region Agent
        services.AddScoped<ICreateAgentInputPort, CreateAgentInteractor>();
        services.AddScoped<IGetAgentInputPort, GetAgentInteractor>();
        services.AddScoped<IUpdateAgentInputPort, UpdateAgentInteractor>();
        services.AddScoped<IDeleteAgentInputPort, DeleteAgentInteractor>();
        services.AddScoped<IGetAllAgentInputPort, GetAllAgentInteractor>();
        #endregion
        return services;
    }
}