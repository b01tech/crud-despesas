using API.Handlers;
using API.Controllers;
using Infra.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddInfrastructure(builder.Configuration)
    .AddUseCases();

var app = builder.Build();

app.MapAppEndpoints();
app.UseHttpsRedirection();

app.Run();
