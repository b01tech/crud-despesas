using API.Handlers;
using API.Controllers;
using Infra.Extensions;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

builder.Services
    .AddInfrastructure(builder.Configuration)
    .AddUseCases();

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference("/docs", options =>
{
    options.Title = "CRUD Despesas API";
    options.Theme = ScalarTheme.Purple;
});

app.MapAppEndpoints();
app.UseHttpsRedirection();


app.Run();
