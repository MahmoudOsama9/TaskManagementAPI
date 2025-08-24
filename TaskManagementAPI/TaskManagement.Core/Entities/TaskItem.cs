using TaskManagementAPI.TaskManagement.Core.Enums;

namespace TaskManagementAPI.TaskManagement.Core.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public TaskState Status { get; set; } 
        public TaskPriority Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public int? AssignedUserId { get; set; }
        public User? AssignedUser { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
