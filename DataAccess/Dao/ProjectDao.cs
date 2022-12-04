using Dapper;
using System.Data.SqlClient;

namespace DataAccess.Dao;

public class ProjectDao : IProjectDao
{
    private readonly SqlConnection _db;

    public ProjectDao(string connectionString)
    {
        _db = new SqlConnection(connectionString);
    }

    public async Task<IEnumerable<Project>> GetAllAsync()
    {
        return await _db.QueryAsync<Project>("SELECT Id, Title, Description, ManagerId FROM dbo.Projects");
    }

    public async Task<Project?> GetByIdAsync(int id)
    {
        return await _db.QueryFirstOrDefaultAsync<Project>("SELECT Id, Title, Description, ManagerId FROM dbo.Projects WHERE Id = @Id",
            new { Id = id });
    }
}