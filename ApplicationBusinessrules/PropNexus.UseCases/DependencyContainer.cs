using Microsoft.Extensions.DependencyInjection;
using PropNexus.UseCases.Agent.Create;
using PropNexus.UseCases.Agent.Delete;
using PropNexus.UseCases.Agent.Get;
using PropNexus.UseCases.Agent.GetAll;
using PropNexus.UseCases.Agent.Update;
using PropNexus.UseCases.Client.Create;
using PropNexus.UseCases.Client.Delete;
using PropNexus.UseCases.Client.Get;
using PropNexus.UseCases.Client.GetAll;
using PropNexus.UseCases.Client.Update;
using PropNexus.UseCases.ListingStatus.Create;
using PropNexus.UseCases.ListingStatus.Delete;
using PropNexus.UseCases.ListingStatus.Get;
using PropNexus.UseCases.ListingStatus.GetAll;
using PropNexus.UseCases.ListingStatus.Update;
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
using PropNexus.UseCases.PropertyImage.Create;
using PropNexus.UseCases.PropertyImage.Delete;
using PropNexus.UseCases.PropertyImage.Get;
using PropNexus.UseCases.PropertyImage.GetAll;
using PropNexus.UseCases.PropertyImage.Update;
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
        #region ListingStatus
        services.AddScoped<ICreateListingStatusInputPort, CreateListingStatusInteractor>();
        services.AddScoped<IGetListingStatusInputPort, GetListingStatusInteractor>();
        services.AddScoped<IUpdateListingStatusInputPort, UpdateListingStatusInteractor>();
        services.AddScoped<IDeleteListingStatusInputPort, DeleteListingStatusInteractor>();
        services.AddScoped<IGetAllListingStatusInputPort, GetAllListingStatusInteractor>();
        #endregion
        #region Cliente
        services.AddScoped<ICreateClientInputPort, CreateClientInteractor>();
        services.AddScoped<IGetClientInputPort, GetClientInteractor>();
        services.AddScoped<IUpdateClientInputPort, UpdateClientInteractor>();
        services.AddScoped<IDeleteClientInputPort, DeleteClientInteractor>();
        services.AddScoped<IGetAllClientInputPort, GetAllClientInteractor>();
        #endregion
        #region PropertyImage
        services.AddScoped<ICreatePropertyImageInputPort, CreatePropertyImageInteractor>();
        services.AddScoped<IGetPropertyImageInputPort, GetPropertyImageInteractor>();
        services.AddScoped<IUpdatePropertyImageInputPort, UpdatePropertyImageInteractor>();
        services.AddScoped<IDeletePropertyImageInputPort, DeletePropertyImageInteractor>();
        services.AddScoped<IGetAllPropertyImageInputPort, GetAllPropertyImageInteractor>();
        #endregion
        return services;
    }
}