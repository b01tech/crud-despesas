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

        group.MapGet("/", async ([FromServices]IGetAllDespesaUseCase useCase) =>
        {
            var despesas = await useCase.ExecuteAsync();
            return Results.Ok(despesas);
        });
        group.MapGet("/{id:guid}", async ([FromRoute]Guid id, [FromServices]IGetDespesaUseCase useCase) =>
        {
            var despesa = await useCase.ExecuteAsync(id);
            return Results.Ok(despesa);
        });
        group.MapDelete("/{id:guid}", async ([FromRoute]Guid id, [FromServices]IRemoveDespesaUseCase useCase) =>
        {
            await useCase.ExecuteAsync(id);
            return Results.NoContent();
        });
        group.MapPut("/", async ([FromRoute]Guid id, [FromBody]UpdateDespesaDto request, [FromServices]IUpdateDespesaUseCase useCase) =>
        {
            await useCase.ExecuteAsync(request);
            return Results.NoContent();
        });
    }
}
