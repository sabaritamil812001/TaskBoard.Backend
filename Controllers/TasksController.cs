using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoard.Data;
using TaskBoard.DTOs;
using TaskBoard.Models;

namespace TaskBoard.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    [Produces("application/json")]
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _db;

        public TasksController(AppDbContext db)
        {
            _db = db;
        }

        private string User => HttpContext.Items["User"]?.ToString() ?? "unknown";

        // ---------------- GET TASKS ----------------
        [HttpGet]
        [ProducesResponseType(typeof(PagedResult<TaskItem>), StatusCodes.Status200OK)]
        public async Task<ActionResult<PagedResult<TaskItem>>> Get()
        {
            var tasks = await _db.Tasks
                .OrderByDescending(t => t.UpdatedAt)
                .ToListAsync();

            return Ok(new PagedResult<TaskItem>
            {
                Items = tasks,
                TotalCount = tasks.Count
            });
        }

        // ---------------- CREATE TASK ----------------
        [HttpPost]
        [ProducesResponseType(typeof(TaskItem), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TaskItem>> Create([FromBody] TaskCreateDto dto)
        {
            var task = new TaskItem
            {
                Id = Guid.NewGuid(),
                Title = dto.Title,
                Description = dto.Description,
                Status = dto.Status,
                Priority = dto.Priority,
                Assignee = dto.Assignee,
                DueDate = dto.DueDate,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _db.Tasks.Add(task);

            _db.AuditLogs.Add(new AuditLog
            {
                Id = Guid.NewGuid(),
                EntityType = "TaskItem",
                EntityId = task.Id,
                Action = "Created",
                ChangedBy = User,
                ChangedAt = DateTime.UtcNow,
                Changes = "{}"
            });

            await _db.SaveChangesAsync();
            return Created();
        }

        // ---------------- UPDATE TASK ----------------
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(TaskItem), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TaskItem>> Update(Guid id, [FromBody] TaskUpdateDto dto)
        {
            var task = await _db.Tasks.FindAsync(id);
            if (task == null) return NotFound();

            task.Title = dto.Title;
            task.Description = dto.Description;
            task.Status = dto.Status;
            task.Priority = dto.Priority;
            task.Assignee = dto.Assignee;
            task.DueDate = dto.DueDate;
            task.UpdatedAt = DateTime.UtcNow;

            _db.AuditLogs.Add(new AuditLog
            {
                Id = Guid.NewGuid(),
                EntityType = "TaskItem",
                EntityId = task.Id,
                Action = "Updated",
                ChangedBy = User,
                ChangedAt = DateTime.UtcNow,
                Changes = "{}"
            });

            await _db.SaveChangesAsync();
            return Ok(task);
        }

        // ---------------- DELETE TASK ----------------
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var task = await _db.Tasks.FindAsync(id);
            if (task == null) return NotFound();

            _db.Tasks.Remove(task);

            _db.AuditLogs.Add(new AuditLog
            {
                Id = Guid.NewGuid(),
                EntityType = "TaskItem",
                EntityId = id,
                Action = "Deleted",
                ChangedBy = User,
                ChangedAt = DateTime.UtcNow,
                Changes = "{}"
            });

            await _db.SaveChangesAsync();
            return NoContent();
        }

        // ---------------- ADD COMMENT ----------------
        [HttpPost("{id}/comments")]
        [ProducesResponseType(typeof(Comment), StatusCodes.Status201Created)]
        public async Task<ActionResult<Comment>> AddComment(Guid id, [FromBody] CommentCreateDto dto)
        {
            if (!await _db.Tasks.AnyAsync(t => t.Id == id))
                return NotFound();

            var comment = new Comment
            {
                Id = Guid.NewGuid(),
                TaskId = id,
                Message = dto.Message,
                CreatedBy = User,
                CreatedAt = DateTime.UtcNow
            };

            _db.Comments.Add(comment);
            await _db.SaveChangesAsync();

            return Created();
        }

        // ---------------- GET COMMENTS ----------------
        [HttpGet("{id}/comments")]
        [ProducesResponseType(typeof(List<Comment>), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<Comment>>> GetComments(Guid id)
        {
            var comments = await _db.Comments
                .Where(c => c.TaskId == id)
                .OrderBy(c => c.CreatedAt)
                .ToListAsync();

            return Ok(comments);
        }
    }
}