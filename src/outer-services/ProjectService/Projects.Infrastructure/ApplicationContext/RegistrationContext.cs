using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Projects.Infrastructure.ApplicationContext
{
    public static class RegistrationContext
    {
        public static IServiceCollection AddAppContext(this IServiceCollection services)
        {
            string connection = "Host=localhost;Port=5432;Database=TaskService;Username=TaskService;Password=TaskService";
            services.AddDbContext<AppContext>(options => options.UseNpgsql(connection));
            return services;
        }
    }
}
