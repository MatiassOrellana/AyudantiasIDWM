using Ayudantia1.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<DataContext>(opt => opt.UseSqlite("DataSource = Ayudantia1"));

app.MapGet("/", () => "Hello World!");

app.Run();
