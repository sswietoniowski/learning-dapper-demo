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

    public IEnumerable<Project> GetAll()
    {
        return _db.Query<Project>("SELECT Id, Title, Description, ManagerId FROM dbo.Projects").ToList();
    }

    public Project? GetById(int id)
    {
        return _db.Query<Project>("SELECT Id, Title, Description, ManagerId FROM dbo.Projects WHERE Id = @Id",
            new { Id = id }).FirstOrDefault();
    }
}