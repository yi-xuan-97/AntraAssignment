using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;

namespace eShop.Infrastructure.Repository;

public class CartItemRepository: BaseRepository<CartItem>, ICartItemRepository
{
    public CartItemRepository(eShopDbContext eb) : base(eb)
    {
    }

    public IEnumerable<CartItem> GetbyShoppingCartId(int id)
    {
        return _context.Set<CartItem>().Where(x=> x.ShoppingCartId==id).ToList();
    }
}