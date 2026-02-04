using Core.Dtos;
using Core.UseCases.Despesa;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public static class DespesasController
{
    public static void MapAppEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("despesas").WithTags("Despesas");

        group.MapPost("/", async ([FromBody] CreateDespesaDto request, [FromServices] ICreateDespesaUseCase useCase) =>
        {
            await useCase.ExecuteAsync(request);
            return Results.Created("", "criado com sucesso");
        }).WithName("CreateDespesa")
        .WithSummary("Cria uma nova despesa")
        .Produces(StatusCodes.Status201Created);

        group.MapGet("/", async ([FromServices] IGetAllDespesaUseCase useCase) =>
        {
            var despesas = await useCase.ExecuteAsync();
            return Results.Ok(despesas);
        }).WithName("GetAllDespesas")
        .WithSummary("Obtém todas as despesas")
        .Produces<List<DespesaDto>>(StatusCodes.Status200OK);

        group.MapGet("/{id:guid}", async ([FromRoute] Guid id, [FromServices] IGetDespesaUseCase useCase) =>
        {
            var despesa = await useCase.ExecuteAsync(id);
            return despesa is not null ? Results.Ok(despesa) : Results.NotFound();
        }).WithName("GetDespesaById")
        .WithSummary("Obtém uma despesa pelo ID")
        .Produces<DespesaDto>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);

        group.MapDelete("/{id:guid}", async ([FromRoute] Guid id, [FromServices] IRemoveDespesaUseCase useCase) =>
        {
            await useCase.ExecuteAsync(id);
            return Results.NoContent();
        }).WithName("DeleteDespesa")
        .WithSummary("Remove uma despesa pelo ID")
        .Produces(StatusCodes.Status204NoContent);

        group.MapPut("/", async ([FromBody] UpdateDespesaDto request, [FromServices] IUpdateDespesaUseCase useCase) =>
        {
            await useCase.ExecuteAsync(request);
            return Results.NoContent();
        }).WithName("UpdateDespesa")
        .WithSummary("Atualiza uma despesa existente")
        .Produces(StatusCodes.Status204NoContent);
    }
}
