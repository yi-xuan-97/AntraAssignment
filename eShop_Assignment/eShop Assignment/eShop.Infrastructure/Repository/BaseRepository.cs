using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repository;

public class BaseRepository<T>:IRepository<T> where T: class
{
    //can only be modify through constructor
    //dependency injection
    protected readonly eShopDbContext _context;
    public BaseRepository(eShopDbContext eb)
    {
        _context = eb;
    }
    public int Insert(T entity)
    {
        _context.Set<T>().Add(entity);
        return _context.SaveChanges();
    }

    public int Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        return _context.SaveChanges();
    }

    public int Delete(int id)
    {
        var entity = GetById(id);
        _context.Set<T>().Remove(entity);
        return _context.SaveChanges();
    }

    public virtual IEnumerable<T> GetAll()
    {
        //without ToList() our code will be exucute but will not give us a result
        //delay execution
        //enforce immediate execution 
        return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id); //where(X=>x.id==id.firstordefault()
    }
}