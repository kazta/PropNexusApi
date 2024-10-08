using Microsoft.Extensions.DependencyInjection;
using PropNexus.Presenters.Agent;
using PropNexus.Presenters.Client;
using PropNexus.Presenters.ListingStatus;
using PropNexus.Presenters.Owner;
using PropNexus.Presenters.Owners;
using PropNexus.Presenters.PorpertyTrace;
using PropNexus.Presenters.Property;
using PropNexus.Presenters.PropertyImage;
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
        #region PropertyTrace
        services.AddScoped<ICreatePropertyTraceOutputPort, CreatePropertyTracePresenter>();
        services.AddScoped<IGetPropertyTraceOutputPort, GetPropertyTracePresenter>();
        services.AddScoped<IUpdatePropertyTraceOutputPort, UpdatePropertyTracePresenter>();
        services.AddScoped<IDeletePropertyTraceOutputPort, DeletePropertyTracePresenter>();
        services.AddScoped<IGetAllPropertyTraceOutputPort, GetAllPropertyTracePresenter>();
        #endregion
        #region Agent
        services.AddScoped<ICreateAgentOutputPort, CreateAgentPresenter>();
        services.AddScoped<IGetAgentOutputPort, GetAgentPresenter>();
        services.AddScoped<IUpdateAgentOutputPort, UpdateAgentPresenter>();
        services.AddScoped<IDeleteAgentOutputPort, DeleteAgentPresenter>();
        services.AddScoped<IGetAllAgentOutputPort, GetAllAgentPresenter>();
        #endregion
        #region ListingStatus
        services.AddScoped<ICreateListingStatusOutputPort, CreateListingStatusPresenter>();
        services.AddScoped<IGetListingStatusOutputPort, GetListingStatusPresenter>();
        services.AddScoped<IUpdateListingStatusOutputPort, UpdateListingStatusPresenter>();
        services.AddScoped<IDeleteListingStatusOutputPort, DeleteListingStatusPresenter>();
        services.AddScoped<IGetAllListingStatusOutputPort, GetAllListingStatusPresenter>();
        #endregion
        #region Cliente
        services.AddScoped<ICreateClientOutputPort, CreateClientPresenter>();
        services.AddScoped<IGetClientOutputPort, GetClientPresenter>();
        services.AddScoped<IUpdateClientOutputPort, UpdateClientPresenter>();
        services.AddScoped<IDeleteClientOutputPort, DeleteClientPresenter>();
        services.AddScoped<IGetAllClientOutputPort, GetAllClientPresenter>();
        #endregion
        #region PropertyImage
        services.AddScoped<ICreatePropertyImageOutputPort, CreatePropertyImagePresenter>();
        services.AddScoped<IGetPropertyImageOutputPort, GetPropertyImagePresenter>();
        services.AddScoped<IUpdatePropertyImageOutputPort, UpdatePropertyImagePresenter>();
        services.AddScoped<IDeletePropertyImageOutputPort, DeletePropertyImagePresenter>();
        services.AddScoped<IGetAllPropertyImageOutputPort, GetAllPropertyImagePresenter>();
        #endregion
        return services;
    }
}