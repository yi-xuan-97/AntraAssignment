using eShop.ApplicationCore.Entities;

namespace eShop.ApplicationCore.RepositoryInterface;

public interface ICartItemRepository: IRepository<CartItem>
{
    IEnumerable<CartItem> GetbyShoppingCartId(int id);
    CartItem? GetByProductId(int id, int pid);
}