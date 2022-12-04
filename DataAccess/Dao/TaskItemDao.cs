using Dapper;
using System.Data.SqlClient;

namespace DataAccess.Dao;

public class TaskItemDao : ITaskItemDao
{
    private readonly SqlConnection _db;

    public TaskItemDao(string connectionString)
    {
        _db = new SqlConnection(connectionString);
    }

    public IEnumerable<TaskItem> GetAll()
    {
        return _db.Query<TaskItem>("SELECT Id, Title, Description, ProjectId, AssignedToId FROM dbo.TaskItems").ToList();
    }

    public TaskItem? GetById(int id)
    {
        return _db.Query<TaskItem>("SELECT Id, Title, Description, ProjectId, AssignedToId FROM dbo.TaskItems WHERE Id = @Id",
            new { Id = id }).FirstOrDefault();
    }
}