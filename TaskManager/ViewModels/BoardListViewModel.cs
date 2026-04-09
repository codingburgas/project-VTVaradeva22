using System.ComponentModel.DataAnnotations;
using TaskItemStatus = TaskManager.Models.Enums.TaskStatus;

namespace TaskManager.ViewModels;

public class BoardListViewModel
{
    public int? Id { get; set; }

    [Required]
    public int BoardId { get; set; }

    [Required]
    [StringLength(80)]
    public string Title { get; set; } = string.Empty;

    [Required]
    public TaskItemStatus Status { get; set; } = TaskItemStatus.ToDo;
}
