using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repository;

public class CategoryRepository: BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(eShopDbContext eb) : base(eb)
    {
    }

    public override IEnumerable<Category> GetAll()
    {
        return _context.Set<Category>().Include( p => p.Products).ToList();
    }
}