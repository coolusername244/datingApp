using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Here we are adding teh DataContext as a service
// We will need access to the class to access and update the database
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
