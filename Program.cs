var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<

app.MapGet("/", () => "Hello World!");

app.Run();
