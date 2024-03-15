using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;

namespace eShop.Infrastructure.Repository;

public class ShoppingCartRepository: BaseRepository<ShoppingCart>, IShoppingCartRepository
{
    public ShoppingCartRepository(eShopDbContext eb) : base(eb)
    {
    }

    public ShoppingCart GetByCustomerId(int id)
    {
        return _context.Set<ShoppingCart>().Where(x=>x.CustomerId==id).FirstOrDefault();
    }
}