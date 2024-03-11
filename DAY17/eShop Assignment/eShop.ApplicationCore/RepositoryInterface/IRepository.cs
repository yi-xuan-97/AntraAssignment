namespace eShop.ApplicationCore.RepositoryInterface;

public interface IRepository<T> where T: class
{
    int Insert(T entity);
    T GetById(int id);
    int Delete(int id);
    int Update(T entity);
    IEnumerable<T> GetAll();
    
}