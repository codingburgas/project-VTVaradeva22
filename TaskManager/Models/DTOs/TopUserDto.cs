namespace TaskManager.Models.DTOs;

public class TopUserDto
{
    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public int CompletedTasks { get; set; }
}
