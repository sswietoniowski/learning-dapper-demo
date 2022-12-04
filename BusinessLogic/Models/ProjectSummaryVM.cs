namespace BusinessLogic.Models;

public class ProjectSummaryVM
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public string ManagerName { get; set; } = default!;
    public int NumberOfTasks { get; set; }
}