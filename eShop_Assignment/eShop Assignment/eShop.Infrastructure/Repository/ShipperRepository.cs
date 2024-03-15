using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repository;

public class ShipperRepository: BaseRepository<Shipper>, IShipperRepository
{
    public ShipperRepository(eShopDbContext eb) : base(eb)
    {
    }
    
}