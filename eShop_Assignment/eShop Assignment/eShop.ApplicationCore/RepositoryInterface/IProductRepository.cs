using eShop.ApplicationCore.Entities;

namespace eShop.ApplicationCore.RepositoryInterface;

public interface IProductRepository:IRepository<Product>
{
    Product GetByName(string name);
}