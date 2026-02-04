namespace API.Controllers;

public static class EndpointExtensions
{
    public static void MapAppEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapDespesasEndpoints();
        app.MapUsuarioEndpoints();
    }
}
