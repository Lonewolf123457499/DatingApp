using API.DataContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();


var app = builder.Build();


app.UseCors(policy =>
{
    policy.AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins("http://localhost:4200");
});

app.MapControllers();

app.Run();
