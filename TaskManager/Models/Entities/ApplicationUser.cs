using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TaskManager.Models.Entities;

public class ApplicationUser : IdentityUser
{
    // User full name shown in the UI
    [Required]
    [StringLength(100)]
    
    // An additional field with a capital letter added to the standard IdentityUser
    public string FullName { get; set; } = string.Empty;

    // Boards created by this user
    public ICollection<Board> Boards { get; set; } = new List<Board>();

    // Tasks assigned to this user
    public ICollection<TaskItem> AssignedTasks { get; set; } = new List<TaskItem>();
}
