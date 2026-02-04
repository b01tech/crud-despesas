using Core.Services;

namespace API.Services;

public static class ServicesExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<IEncrypter, Encrypter>();
        return services;
    }
}
