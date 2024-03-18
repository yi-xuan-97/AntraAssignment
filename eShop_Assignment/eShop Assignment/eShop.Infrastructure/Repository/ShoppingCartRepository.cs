using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repository;

public class ShoppingCartRepository: BaseRepository<ShoppingCart>, IShoppingCartRepository
{
    public ShoppingCartRepository(eShopDbContext eb) : base(eb)
    {
    }

    public override IEnumerable<ShoppingCart> GetAll()
    {
        return _context.Set<ShoppingCart>().Include(s => s.CartItems).ToList();
    }

    public ShoppingCart GetByCustomerId(int id)
    {
        return _context.Set<ShoppingCart>().Where(x=>x.CustomerId==id).FirstOrDefault();
    }
}