using TaskManager.Models.Enums;
using TaskItemStatus = TaskManager.Models.Enums.TaskStatus;

namespace TaskManager.Models.DTOs;

public class TaskDto
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string BoardName { get; set; } = string.Empty;

    public string ListTitle { get; set; } = string.Empty;

    public string? AssignedToName { get; set; }

    public DateTime? Deadline { get; set; }

    public Priority Priority { get; set; }

    public TaskItemStatus Status { get; set; }

    public bool IsOverdue { get; set; }

    public DateTime CreatedAt { get; set; }
}
