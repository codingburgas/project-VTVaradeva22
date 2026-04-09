using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskManager.Models.Enums;

namespace TaskManager.ViewModels;

public class TaskViewModel
{
    public int? Id { get; set; }

    [Required]
    public int BoardId { get; set; }

    [Required]
    [Display(Name = "List")]
    public int BoardListId { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;

    [StringLength(1000)]
    public string Description { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime? Deadline { get; set; }

    [Required]
    public Priority Priority { get; set; } = Priority.Medium;

    [Display(Name = "Assigned user")]
    public string? AssignedToId { get; set; }

    public IEnumerable<SelectListItem> AvailableBoards { get; set; } = [];

    public IEnumerable<SelectListItem> AvailableLists { get; set; } = [];

    public IEnumerable<SelectListItem> AvailableUsers { get; set; } = [];
}
