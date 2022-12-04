namespace DataAccess.Dao;

public interface IDao<T> where T : class
{
    public IEnumerable<T> GetAll();
    public T? GetById(int id);
}