using Microsoft.EntityFrameworkCore;
using Projects.Core.Entities;
using Projects.Core.Entities.ZATICHKI;
using Projects.Infrastructure.ApplicationContext.Configuration;
using Task = Projects.Core.Entities.Task;

namespace Projects.Infrastructure.ApplicationContext
{
    internal class ProjectDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Commentary> Commentaries { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<Worker> Workers { get; set; }


        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
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


