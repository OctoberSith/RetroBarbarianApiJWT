using Microsoft.EntityFrameworkCore;
using RetroModels;

namespace RetroDL
{

    public class RetroStoreDBContext : DbContext
    {
        public DbSet<Customers> Customers {get; set;}
        public DbSet<Inventory> Inventory {get; set;}
        public DbSet<CartItems> CartItems {get; set;}
        public DbSet<Orders> Orders {get; set;}
        public DbSet<Products> Products {get; set;}
        public DbSet<Stores> Stores {get; set;}

        public RetroStoreDBContext() : base()
        {

        }

        public RetroStoreDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder p_ModelBuilder)
        {
            p_ModelBuilder.Entity<Products>()
                .Property(p => p.ProductPrice)
                .HasColumnType("decimal(10,2)");
            p_ModelBuilder.Entity<Inventory>()
                .Property(p => p.ProductPrice)
                .HasColumnType("decimal(10,2)");
            p_ModelBuilder.Entity<CartItems>()
                .Property(p => p.ProductPrice)
                .HasColumnType("decimal(10,2)");
            p_ModelBuilder.Entity<Orders>()
                .Property(p => p.OrderTotal)
                .HasColumnType("decimal(10,2)");

            p_ModelBuilder.Entity<Orders>().Ignore(x => x.OrderCart);
            base.OnModelCreating(p_ModelBuilder);

        }

    }


}