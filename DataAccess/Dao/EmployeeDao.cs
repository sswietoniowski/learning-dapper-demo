using System.Data.SqlClient;
using Dapper;

namespace DataAccess.Dao;

public class EmployeeDao : IEmployeeDao
{
    private readonly SqlConnection _db;

    public EmployeeDao(string connectionString)
    {
        _db = new SqlConnection(connectionString);
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        return await _db.QueryAsync<Employee>("SELECT Id, Name, SuperiorId FROM dbo.Employees");
    }

    public async Task<Employee?> GetByIdAsync(int id)
    {
        return await _db.QueryFirstOrDefaultAsync<Employee>("SELECT Id, Name, SuperiorId FROM dbo.Employees WHERE Id = @Id", new { Id = id });
    }
}