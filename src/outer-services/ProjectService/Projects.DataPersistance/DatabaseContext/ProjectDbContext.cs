using Microsoft.EntityFrameworkCore;
using Projects.Core.Entities;
using Projects.DataPersistance.Configurations;
using Task = Projects.Core.Entities.Task;

namespace Projects.DataPersistance.DatabaseContext.ProjectDbContext
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Release> Releases { get; set; }

        public DbSet<Commentary> Commentaries { get; set; }


        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TasksConfiguration());
            modelBuilder.ApplyConfiguration(new ReleasesConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectsConfiguration());
            modelBuilder.ApplyConfiguration(new CommentariesConfiguration());
        }
    }
}