using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementAPI.TaskManagement.Core.Entities;

namespace TaskManagementAPI.TaskManagement.Core.Configurations
{
    public class TaskItemConfiguration : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.ToTable("Tasks");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.Status)
                .IsRequired();

            builder.Property(t =>t.Description)
                .HasMaxLength(2000);

            builder.Property(t => t.Priority)
                .IsRequired();

            builder.HasOne(t => t.Project)
                .WithMany(t => t.Tasks)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.AssignedUser)
                .WithMany(t => t.AssignedTasks)
                .HasForeignKey(t => t.AssignedUserId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(t => t.Comments)
                .WithOne(t => t.TaskItem)
                .HasForeignKey(t => t.TaskItemId);
        }

    }
}
