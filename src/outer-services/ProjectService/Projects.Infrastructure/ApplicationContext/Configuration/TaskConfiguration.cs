using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task = Projects.Core.Entities.Task;

namespace Projects.Infrastructure.ApplicationContext.Configuration
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Tasks");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Priority).IsRequired();
            builder.Property(x => x.Creator).IsRequired();
            builder.Property(x => x.Worker);
            builder.Property(x => x.SpentTime);
            builder.Property(x => x.TimeSpan);

            builder.HasOne(x => x.ParentTask)
                   .WithMany(x => x.SubTask)
                   .HasForeignKey(x => x.ParentTask.Id);

            builder.HasOne(x => x.Release)
                   .WithMany(x => x.TaskList)
                   .HasForeignKey(x => x.Release.Id);

            builder.HasOne(x => x.Project)
                   .WithMany(x => x.TaskList)
                   .HasForeignKey(x => x.Project.Id);
        }
    }

}
