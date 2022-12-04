using System.Data.SqlClient;
using Dapper;

namespace DataAccess;

public class EmployeeDao : IEmployeeDao
{
    private readonly SqlConnection _db;

    public EmployeeDao(string connectionString)
    {
        _db = new SqlConnection(connectionString);
    }

    public IEnumerable<Employee> GetAll()
    {
        return _db.Query<Employee>("SELECT Id, Name, SuperiorId FROM dbo.Employees").ToList();
    }

    public Employee? GetById(int id)
    {
        return _db.Query<Employee>("SELECT Id, Name, SuperiorId FROM dbo.Employees WHERE Id = @Id", new { Id = id }).FirstOrDefault();
    }
}