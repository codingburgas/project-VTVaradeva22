namespace TaskManager.ViewModels;

public class UserManagementViewModel
{
    public string Id { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Role { get; set; } = string.Empty;

    public int AssignedTasks { get; set; }

    public int CompletedTasks { get; set; }
}
