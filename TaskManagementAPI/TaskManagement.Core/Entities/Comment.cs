namespace TaskManagementAPI.TaskManagement.Core.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int TaskItemId { get; set; }

        public int UserId { get; set; }

        public TaskItem TaskItem { get; set; } = null!;

        public User User { get; set; } = null!;
    }
}
