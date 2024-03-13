using FluentAPI.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.Infrustructure.Data;

public class eShopDbContext:DbContext
{
    public eShopDbContext()
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Shipper>().HasKey(x => x.Id);
        base.OnModelCreating(modelBuilder);
    }
}