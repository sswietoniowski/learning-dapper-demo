namespace DataAccess;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public int ManagerId { get; set; }
}