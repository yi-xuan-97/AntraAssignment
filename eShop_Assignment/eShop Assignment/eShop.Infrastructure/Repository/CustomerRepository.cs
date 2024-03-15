using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;

namespace eShop.Infrastructure.Repository;

public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(eShopDbContext eb) : base(eb)
    {
    }

}