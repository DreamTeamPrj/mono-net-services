using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Projects.Infrastructure.ApplicationContext
{
    public static class RegistrationContext 
    {
        public static IServiceCollection AddAppContext(this IServiceCollection services)
        {
            string connection = "Host=localhost;Port=5432;Database=TaskDb;Username=postgres;Password=kartofel12341";
            services.AddDbContext<ProjectDbContext>(options => options.UseNpgsql(connection));
            return services;
        }
    }
}
