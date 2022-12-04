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

    public IEnumerable<Manager> GetAll()
    {
        return _db.Query<Manager>("SELECT e.Id, Name, SuperiorId FROM dbo.Employees AS e INNER JOIN dbo.Managers AS m ON e.Id = m.Id").ToList();
    }

    public Manager? GetById(int id)
    {
        return _db.Query<Manager>("SELECT e.Id, Name, SuperiorId FROM dbo.Employees AS e INNER JOIN dbo.Managers AS m ON e.Id = m.Id WHERE e.Id = @Id",
            new { Id = id }).FirstOrDefault();
    }
}