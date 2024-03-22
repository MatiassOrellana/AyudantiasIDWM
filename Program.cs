using Ayudantia1.src.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(opt => opt.UseSqlite("Data Source=Ayudantia1.db"));

var app = builder.Build();

app.Run();
