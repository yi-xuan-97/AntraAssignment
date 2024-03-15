using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;

namespace eShop.Infrastructure.Repository;

public class CategoryRepository: BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(eShopDbContext eb) : base(eb)
    {
    }
}