using API.Controllers;
using API.Handlers;
using API.Services;
using Infra.Extensions;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddAuthorization();

builder.Services
    .AddInfrastructure(builder.Configuration)
    .AddUseCases()
    .AddAppServices();

var app = builder.Build();


app.MapOpenApi();
app.MapScalarApiReference("/docs", options =>
{
    options.Title = "CRUD Despesas API";
    options.Theme = ScalarTheme.Purple;
    options.PersistentAuthentication = true;
});

app.MapAppEndpoints();
app.UseHttpsRedirection();
app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.Run();
