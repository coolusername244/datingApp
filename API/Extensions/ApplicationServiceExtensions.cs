using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
  public static class ApplicationServiceExtensions
  {
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
      // Here we are adding teh DataContext as a service
      // We will need access to the class to access and update the database
      services.AddDbContext<DataContext>(opt =>
      {
        opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
      });
      services.AddCors();
      services.AddScoped<ITokenService, TokenService>();

      return services;
    }
  }
}

