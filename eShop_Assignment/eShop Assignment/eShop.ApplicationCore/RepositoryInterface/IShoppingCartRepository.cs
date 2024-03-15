using eShop.ApplicationCore.Entities;

namespace eShop.ApplicationCore.RepositoryInterface;

public interface IShoppingCartRepository: IRepository<ShoppingCart>
{
    ShoppingCart GetByCustomerId(int id);
}