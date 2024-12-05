using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projects.Core.Entities;
namespace Projects.Infrastructure.ApplicationContext.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Tag).IsRequired();

            builder.HasOne(x => x.ParentProject)
                   .WithMany(x => x.SubProjects)
                   .HasForeignKey(x => x.ParentProject.Id);
        }
    }

}
