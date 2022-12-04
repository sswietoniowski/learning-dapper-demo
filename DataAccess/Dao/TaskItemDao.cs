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

    public async Task<IEnumerable<TaskItem>> GetAllAsync()
    {
        return await _db.QueryAsync<TaskItem>("SELECT Id, Title, Description, ProjectId, AssignedToId FROM dbo.TaskItems");
    }

    public async Task<TaskItem?> GetByIdAsync(int id)
    {
        return await _db.QueryFirstOrDefaultAsync<TaskItem>("SELECT Id, Title, Description, ProjectId, AssignedToId FROM dbo.TaskItems WHERE Id = @Id",
            new { Id = id });
    }
}