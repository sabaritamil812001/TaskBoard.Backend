using System.ComponentModel.DataAnnotations;

namespace TaskBoard.Models
{
    public class TaskItem
    {
        public Guid Id { get; set; }

        [Required, MinLength(5), MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        public TaskItemStatus Status { get; set; }
        public Priority Priority { get; set; }

        public string? Assignee { get; set; }
        public DateTime? DueDate { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [Timestamp] 
        public byte[] RowVersion { get; set; }
    }
}