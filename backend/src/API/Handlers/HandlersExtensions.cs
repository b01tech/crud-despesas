using API.Handlers.Despesa;
using API.Handlers.Usuario;
using Core.UseCases.Despesa;
using Core.UseCases.Usuario;

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

        services.AddScoped<ICreateUsuarioUseCase, CreateUsuarioUseCase>();
        services.AddScoped<ILoginUsuarioUseCase, LoginUsuarioUseCase>();

        return services;
    }
}
