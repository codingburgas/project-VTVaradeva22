using System.ComponentModel.DataAnnotations;

namespace TaskManager.ViewModels;

public class BoardViewModel
{
    public int? Id { get; set; }

    [Required]
    [StringLength(80)]
    public string Name { get; set; } = string.Empty;

    [StringLength(250)]
    public string Description { get; set; } = string.Empty;
}
