using eShop.ApplicationCore.Entities;

namespace eShop.ApplicationCore.ServiceInterface;

public interface IShoppingCartService
{
    IEnumerable<Product> GetAllProducts(int id);
    decimal GetTotal(int id);
    void AddToCart(int uid, int id);
}