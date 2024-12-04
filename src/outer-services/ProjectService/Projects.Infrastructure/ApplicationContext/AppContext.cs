using Microsoft.EntityFrameworkCore;
using Projects.Core.Entities;
using Projects.Infrastructure.ApplicationContext.Configuration;
using Task = Projects.Core.Entities.Task;

namespace Projects.Infrastructure.ApplicationContext
{
    internal class AppContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Commentary> Commentaries { get; set; }

        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
            modelBuilder.ApplyConfiguration(new ReleaseConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new CommentariesConfiguration());
        }
    }
}


