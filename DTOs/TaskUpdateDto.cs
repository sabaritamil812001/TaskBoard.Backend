using System.ComponentModel.DataAnnotations;

namespace TaskBoard.DTOs
{
    public class TaskUpdateDto : TaskCreateDto
    {
        [Required]
        public byte[] RowVersion { get; set; }
    }
}