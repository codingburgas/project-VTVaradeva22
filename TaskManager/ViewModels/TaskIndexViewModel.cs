using Microsoft.AspNetCore.Mvc.Rendering;
using TaskManager.Models.DTOs;
using TaskManager.Models.Enums;
using TaskItemStatus = TaskManager.Models.Enums.TaskStatus;

namespace TaskManager.ViewModels;

public class TaskIndexViewModel
{
    public List<TaskDto> Tasks { get; set; } = [];

    public int? SelectedBoardId { get; set; }

    public Priority? SelectedPriority { get; set; }

    public TaskItemStatus? SelectedStatus { get; set; }

    public IEnumerable<SelectListItem> Boards { get; set; } = [];
}
