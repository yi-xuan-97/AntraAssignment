using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;

namespace eShop.Infrastructure.Repository;

public class OrderRepository: BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(eShopDbContext eb) : base(eb)
    {
    }
}