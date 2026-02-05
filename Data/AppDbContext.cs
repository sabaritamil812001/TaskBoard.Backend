using Microsoft.EntityFrameworkCore;
using TaskBoard.Models;

namespace TaskBoard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<TaskItem> Tasks => Set<TaskItem>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}