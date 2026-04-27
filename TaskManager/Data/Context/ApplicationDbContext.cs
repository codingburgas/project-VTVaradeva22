using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models.Entities;

namespace TaskManager.Data.Context;

// The class inherits from IdentityDbContext<ApplicationUser>, which automatically includes the Identity tables.
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    // The constructor accepts DbContextOptions
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Main project tables.
    public DbSet<Board> Boards => Set<Board>();

    public DbSet<BoardList> BoardLists => Set<BoardList>();

    public DbSet<TaskItem> Tasks => Set<TaskItem>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Board owner relationship with Restrict 
        builder.Entity<Board>()
            .HasOne(b => b.Owner)
            .WithMany(u => u.Boards)
            .HasForeignKey(b => b.OwnerId)
            .OnDelete(DeleteBehavior.Restrict);

        // A board contains many lists
        // board -> lists cascade
        builder.Entity<BoardList>()
            .HasOne(l => l.Board)
            .WithMany(b => b.Lists)
            .HasForeignKey(l => l.BoardId)
            .OnDelete(DeleteBehavior.Cascade);

        // A board also keeps a direct collection of its tasks
        // board -> tasks cascade
        builder.Entity<TaskItem>()
            .HasOne(t => t.Board)
            .WithMany(b => b.Tasks)
            .HasForeignKey(t => t.BoardId)
            .OnDelete(DeleteBehavior.Cascade);

        // A task must stay linked to a valid list
        // task -> list restrict
        builder.Entity<TaskItem>()
            .HasOne(t => t.BoardList)
            .WithMany(l => l.Tasks)
            .HasForeignKey(t => t.BoardListId)
            .OnDelete(DeleteBehavior.Restrict);

        // If an assigned user is removed, keep the task but clear the assignee/task assignee set null on delete
        builder.Entity<TaskItem>()
            .HasOne(t => t.AssignedTo)
            .WithMany(u => u.AssignedTasks)
            .HasForeignKey(t => t.AssignedToId)
            .OnDelete(DeleteBehavior.SetNull);

        // Helpful indexes for common queries and filters
        builder.Entity<Board>()
            .HasIndex(b => new { b.OwnerId, b.Name });

        builder.Entity<BoardList>()
            .HasIndex(l => new { l.BoardId, l.Position });

        builder.Entity<TaskItem>()
            .HasIndex(t => new { t.BoardId, t.Status, t.Priority });

        builder.Entity<TaskItem>()
            .HasIndex(t => t.Deadline);
    }
}
