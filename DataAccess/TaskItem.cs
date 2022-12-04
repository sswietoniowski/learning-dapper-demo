namespace DataAccess;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public int? AssignedToId { get; set; }
    public int ProjectId { get; set; }
}