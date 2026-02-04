using API.Handlers.Despesa;
using Core.UseCases.Despesa;

namespace API.Handlers;

public static class HandlersExtensions
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<ICreateDespesaUseCase, CreateDespesaUseCase>();
        services.AddScoped<IUpdateDespesaUseCase, UpdateDespesaUseCase>();
        services.AddScoped<IRemoveDespesaUseCase, RemoveDespesaUseCase>();
        services.AddScoped<IGetAllDespesaUseCase, GetAllDespesaUseCase>();
        services.AddScoped<IGetDespesaUseCase, GetDespesaUseCase>();
        return services;
    }
}
