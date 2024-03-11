using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;

namespace eShop.Infrastructure.Repository;

public class OrderDetailRepository: BaseRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(eShopDbContext eb) : base(eb)
    {
    }
}