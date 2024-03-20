using eShop.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Data;

public class eShopDbContext: DbContext
{
    public eShopDbContext(DbContextOptions<eShopDbContext> options) : base(options)
    {

    }

    public DbSet<Shipper> Shippers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<Authentication> Authentications { get; set; }
    public DbSet<Review> Reviews { get; set; }

}