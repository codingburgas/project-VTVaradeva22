using TaskItemStatus = TaskManager.Models.Enums.TaskStatus;

namespace TaskManager.Models.DTOs;

public class BoardListDto
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public TaskItemStatus Status { get; set; }

    public int Position { get; set; }

    public List<TaskDto> Tasks { get; set; } = [];
}
