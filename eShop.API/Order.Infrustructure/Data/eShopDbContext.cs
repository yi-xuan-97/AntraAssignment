using Microsoft.EntityFrameworkCore;
using Order.ApplicationCore.Entity;

namespace Order.Infrustructure.Data;

public class eShopDbContext: DbContext
{
    public eShopDbContext(DbContextOptions<eShopDbContext> options) : base(options)
    {

    }

    public DbSet<ApplicationCore.Entity.Order> Orders { get; set; }
}