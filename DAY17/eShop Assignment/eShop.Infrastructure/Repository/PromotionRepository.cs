using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;

namespace eShop.Infrastructure.Repository;

public class PromotionRepository: BaseRepository<Promotion>, IPromotionRepository
{
    public PromotionRepository(eShopDbContext eb) : base(eb)
    {
    }
}