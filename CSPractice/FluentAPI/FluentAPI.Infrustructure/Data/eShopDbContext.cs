using FluentAPI.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPI.Infrustructure.Data;

public class eShopDbContext:DbContext
{
    public eShopDbContext(DbContextOptions<eShopDbContext> dbContextOptions): base(dbContextOptions)
    {
        
    }

    public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<ShipperRegion> ShippersRegions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Shippers*/
            modelBuilder.Entity<Shipper>(ConfigureShipper);
            modelBuilder.Entity<Region>(ConfigureRegion);

            modelBuilder.Entity<ShipperRegion>(ConfigureShipperRegion);
            //modelBuilder.Entity<Shipper>().Ignore(x => x.Phone);
            //modelBuilder.Entity<Shipper>().ToTable("Shippers").Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            // modelBuilder.Entity<Shipper>().HasKey(x => new { x.Id, x.Name });

            //Region



            //ShipperRegion

            base.OnModelCreating(modelBuilder);
        }
        private void ConfigureShipper(EntityTypeBuilder<Shipper> builder) {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(40)
                .IsRequired();
                
            builder.Property(x => x.ContactPerson)
                .HasColumnType("varchar")
                .HasMaxLength(40).IsRequired();
            builder.Property(x => x.Phone)
                .HasColumnType("varchar")
                .IsRequired();
            builder.Property(x => x.EmailId)
                .HasColumnType("varchar")
                .HasMaxLength(200);
            
        }
        private void ConfigureRegion(EntityTypeBuilder<Region> builder) {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasColumnType("varchar").HasMaxLength(40).IsRequired();
           }

        private void ConfigureShipperRegion(EntityTypeBuilder<ShipperRegion> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RegionId).IsRequired();
            builder.Property(x => x.ShipperId).IsRequired();

            builder.HasOne(x => x.Region)
                   .WithMany(z => z.ShipperRegions).HasForeignKey(x => x.RegionId);
            builder
                .HasOne(x => x.Shipper)
                .WithMany(x => x.ShipperRegions).HasForeignKey(x => x.ShipperId);

        }
}