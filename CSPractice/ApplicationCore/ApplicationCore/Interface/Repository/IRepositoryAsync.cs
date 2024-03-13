namespace ApplicationCore.Interface.Repository;

public interface IRepositoryAsync<T> where T: class
{
    Task<int> InsertAsync(T entity);
    Task<int> UpdateAsync(T entity);
    Task<int> DeleteAsync(T entity);
    IEnumerable<Task<T>> GetAllAsync(T entity);
    Task<T> GetByIdAsync(T entity);
}