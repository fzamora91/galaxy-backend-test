using Disco.Service.Framework;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostServices(builder.Configuration);

var app = builder.Build();

await app.UseHostSetupAsync();

app.Run();