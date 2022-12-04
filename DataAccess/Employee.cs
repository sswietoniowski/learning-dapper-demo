namespace DataAccess;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public int SuperiorId { get; set; }
}