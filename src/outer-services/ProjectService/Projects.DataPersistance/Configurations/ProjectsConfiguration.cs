using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projects.Core.Entities;
namespace Projects.DataPersistance.Configurations
{
    public class ProjectsConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.ReleaseList)
                .WithOne(x => x.Project)
                .HasForeignKey(x => x.ProjectId);

            builder.HasOne(x => x.ParentProject)
                   .WithMany(x => x.SubProjects)
                   .HasForeignKey(x => x.ParentProjectId);
        }
    }

}
