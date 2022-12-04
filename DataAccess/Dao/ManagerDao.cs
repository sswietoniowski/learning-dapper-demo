using Dapper;
using System.Data.SqlClient;

namespace DataAccess.Dao;

public class ManagerDao : IManagerDao
{
    private readonly SqlConnection _db;

    public ManagerDao(string connectionString)
    {
        _db = new SqlConnection(connectionString);
    }

    public async Task<IEnumerable<Manager>> GetAllAsync()
    {
        return await _db.QueryAsync<Manager>("SELECT e.Id, Name, SuperiorId FROM dbo.Employees AS e INNER JOIN dbo.Managers AS m ON e.Id = m.Id");
    }

    public async Task<Manager?> GetByIdAsync(int id)
    {
        return await _db.QueryFirstOrDefaultAsync<Manager>("SELECT e.Id, Name, SuperiorId FROM dbo.Employees AS e INNER JOIN dbo.Managers AS m ON e.Id = m.Id WHERE e.Id = @Id",
            new { Id = id });
    }
}