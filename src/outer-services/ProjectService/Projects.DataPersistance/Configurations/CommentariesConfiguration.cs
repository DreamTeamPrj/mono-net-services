using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projects.Core.Entities;

namespace Projects.DataPersistance.Configurations
{
    public class CommentariesConfiguration : IEntityTypeConfiguration<Commentary>
    {
        public void Configure(EntityTypeBuilder<Commentary> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.ParentCommentary)
                   .WithMany(x => x.SubComments)
                   .HasForeignKey(x => x.ParentId);

            builder.HasOne(x => x.Task)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.TaskId);
        }
    }

}