using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TaskManager.ViewModels;

public class EditUserRoleViewModel
{
    [Required]
    public string Id { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Role")]
    public string SelectedRole { get; set; } = string.Empty;

    public IEnumerable<SelectListItem> AvailableRoles { get; set; } = [];
}
