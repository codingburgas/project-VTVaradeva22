namespace TaskManager.Models.DTOs;

public class BoardDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string OwnerName { get; set; } = string.Empty;

    public int TotalTasks { get; set; }

    public int CompletedTasks { get; set; }

    public int PendingTasks { get; set; }
}
