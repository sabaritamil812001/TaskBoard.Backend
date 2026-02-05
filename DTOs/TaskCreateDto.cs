using System.ComponentModel.DataAnnotations;
using TaskBoard.Models;

namespace TaskBoard.DTOs
{
    public class TaskCreateDto
    {
        [Required, MinLength(5), MaxLength(100)]
        public string Title { get; set; }

        public string? Description { get; set; }

        // ✅ THIS IS THE CORRECT PROPERTY
        public TaskItemStatus Status { get; set; }

        public Priority Priority { get; set; }
        public string? Assignee { get; set; }
        public DateTime? DueDate { get; set; }
    }
}