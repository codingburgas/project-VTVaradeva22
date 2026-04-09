using TaskManager.Models.DTOs;

namespace TaskManager.ViewModels;

public class DashboardViewModel
{
    public int TotalTasks { get; set; }

    public int CompletedTasks { get; set; }

    public int UpcomingDeadlinesCount { get; set; }

    public double CompletionPercentage { get; set; }

    public Dictionary<string, int> TasksByStatus { get; set; } = new();

    public List<TopUserDto> TopUsersThisWeek { get; set; } = [];

    public List<TaskDto> DeadlineAlerts { get; set; } = [];
}
