using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task = Projects.Core.Entities.Task;

namespace Projects.DataPersistance.Configurations
{
    public class TasksConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.ParentTask)
                   .WithMany(x => x.SubTaskList)
                   .HasForeignKey(x => x.ParentTaskId);

            builder.HasOne(x => x.Release)
                   .WithMany(x => x.TaskList)
                   .HasForeignKey(x => x.ReleaseId);

            builder.HasOne(x => x.Project)
                   .WithMany(x => x.TaskList)
                   .HasForeignKey(x => x.ProjectId);

            builder.HasMany(x => x.Comments)
                .WithOne(x => x.Task)
                .HasForeignKey(x => x.TaskId);
        }
    }

}