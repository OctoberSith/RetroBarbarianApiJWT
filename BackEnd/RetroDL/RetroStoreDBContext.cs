using Microsoft.EntityFrameworkCore;
using RetroModels;

namespace RetroDL
{

    public class RetroStoreDBContext : DbContext
    {
        public DbSet<Customers> Customers {get; set;}
        public DbSet<Inventory> Inventory {get; set;}
        public DbSet<OrderCartItems> OrderCartItems {get; set;}
        public DbSet<Orders> Orders {get; set;}
        public DbSet<Products> Products {get; set;}

        public RetroStoreDBContext() : base()
        {

        }

        public RetroStoreDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder p_ModelBuilder)
        {

            base.OnModelCreating(p_ModelBuilder);
            p_ModelBuilder.Entity<Products>()
                .Property(p => p.ProductPrice)
                .HasColumnType("decimal(10,2)");
            p_ModelBuilder.Entity<Inventory>()
                .Property(p => p.ProductPrice)
                .HasColumnType("decimal(10,2)");
            p_ModelBuilder.Entity<OrderCartItems>()
                .Property(p => p.ProductPrice)
                .HasColumnType("decimal(10,2)");
            p_ModelBuilder.Entity<Orders>()
                .Property(p => p.OrderTotal)
                .HasColumnType("decimal(10,2)");
        }

    }


}