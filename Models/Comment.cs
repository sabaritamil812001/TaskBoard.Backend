using System.ComponentModel.DataAnnotations;

namespace TaskBoard.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }

        [Required, MaxLength(500)]
        public string Message { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}