using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projects.DataPersistance.DatabaseContext.ProjectDbContext;

namespace Projects.DataPersistance
{
    public static class DataPersistanceRegistration
    {
        private const string ProjectDbConnectionString = "ProjectDbSection:ProjectDbConnection";

        public static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            var dbConnection = configuration.GetSection(ProjectDbConnectionString).Value;

            if (dbConnection == null)
            {
                throw new ArgumentNullException(nameof(dbConnection));
            }

            services.AddDbContext<ProjectDbContext>(options => options.UseNpgsql(dbConnection));

            return services;
        }
    }
}