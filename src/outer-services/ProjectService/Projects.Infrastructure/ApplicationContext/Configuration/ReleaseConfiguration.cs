using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projects.Core.Entities;

namespace Projects.Infrastructure.ApplicationContext.Configuration
{
    public class ReleaseConfiguration : IEntityTypeConfiguration<Release>
    {
        public void Configure(EntityTypeBuilder<Release> builder)
        {
            builder.ToTable("Releases");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.FinishDate).IsRequired();

            builder.HasOne(x => x.Project)
                   .WithMany(x => x.ReleaseList)
                   .HasForeignKey(x => x.Project.Id);
        }
    }

}
