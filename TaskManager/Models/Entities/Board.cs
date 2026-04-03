namespace TaskManager.Models.Entities;

public class Board : BaseEntity
{
    public string Title { get; set; }

    public string UserId { get; set; }
    public ApplicationUser User { get; set; }

    public ICollection<TaskItem> Tasks { get; set; }
}