using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projects.Core.Entities;

namespace Projects.Infrastructure.ApplicationContext.Configuration
{
    public class CommentariesConfiguration : IEntityTypeConfiguration<Commentary>
    {
        public void Configure(EntityTypeBuilder<Commentary> builder)
        {
            builder.ToTable("Commentaries");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Author).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();

            builder.HasOne(x => x.ParrentCommentary)
                   .WithMany(x => x.SubComments)
                   .HasForeignKey(x => x.ParrentCommentary.Id);
        }
    }

}
