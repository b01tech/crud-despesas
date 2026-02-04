using Core.Dtos;
using Core.UseCases.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public static class UsuarioController
{
    public static void MapUsuarioEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("usuario").WithTags("Usuário");

        group.MapPost("/", async ([FromBody] CreateUsuarioDto request, [FromServices] ICreateUsuarioUseCase useCase) =>
            {
                await useCase.ExecuteAsync(request);
                return Results.Created("", "usuário criado com sucesso");
            }).WithName("CreateUsuario")
            .WithSummary("Cria um novo usuário")
            .Produces(StatusCodes.Status201Created);

        group.MapPost("/login",
                async ([FromBody] LoginUsuarioDto request, [FromServices] ILoginUsuarioUseCase useCase) =>
                {
                    var token = new TokenResponseDto("teste");
                    await useCase.ExecuteAsync(request);
                    return Results.Ok(token);
                }).WithName("LoginUsuario")
            .WithSummary("Realiza login do usuário")
            .Produces(StatusCodes.Status200OK);
    }
}
