using Core.Dtos;
using Core.UseCases.Despesa;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public static class DespesasController
{
    public static void MapAppEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("despesas").WithTags("Despesas");

        group.MapPost("/", async ([FromBody]CreateDespesaDto request, [FromServices]ICreateDespesaUseCase useCase) =>
        {
            await useCase.ExecuteAsync(request);
            return Results.Created("","criado com sucesso");
        }).WithName("CreateDespesa")
        .WithSummary("Cria uma nova despesa")
        .Produces(StatusCodes.Status201Created);
    }
}
