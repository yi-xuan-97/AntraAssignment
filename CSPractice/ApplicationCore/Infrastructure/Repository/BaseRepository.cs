using ApplicationCore.Interface.Repository;

namespace Infrastructure.Repository;

public class BaseRepository<T>:IRepositoryAsync<T> where T: class
{
    public Task<int> InsertAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Task<T>> GetAllAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(T entity)
    {
        throw new NotImplementedException();
    }
}