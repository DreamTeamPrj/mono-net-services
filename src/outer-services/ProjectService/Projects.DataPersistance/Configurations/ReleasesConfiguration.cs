using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projects.Core.Entities;

namespace Projects.DataPersistance.Configurations
{
    public class ReleasesConfiguration : IEntityTypeConfiguration<Release>
    {
        public void Configure(EntityTypeBuilder<Release> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.TaskList)
                .WithOne(x => x.Release)
                .HasForeignKey(x => x.ReleaseId);

            builder.HasOne(x => x.Project)
                   .WithMany(x => x.ReleaseList)
                   .HasForeignKey(x => x.ProjectId);
        }
    }

}