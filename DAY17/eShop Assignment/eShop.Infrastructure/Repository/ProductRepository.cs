using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;

namespace eShop.Infrastructure.Repository;

public class ProductRepository: BaseRepository<Product>, IProductRepository
{
    public ProductRepository(eShopDbContext eb) : base(eb)
    {
    }

    public Product GetByName(string name)
    {
        return _context.Set<Product>().Find(name);
    }
}