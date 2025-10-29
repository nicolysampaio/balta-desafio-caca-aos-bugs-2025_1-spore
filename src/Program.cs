using BugStore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var cnnString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services
  .AddDbContext<AppDbContext>(dbBuilder => dbBuilder.UseSqlite(cnnString));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
