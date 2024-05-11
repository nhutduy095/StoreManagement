using Microsoft.EntityFrameworkCore;
using StoreManagement.Models;
using static Azure.Core.HttpHeader;

namespace StoreManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Items> Items { get; set; }
        public DbSet<ItemDetails> ItemDetails { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Combos> Combos { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<ItemImage> Images { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=DUY-TRAM;Initial Catalog=OrderApp;Integrated Security=True;TrustServerCertificate=True");
        //    }
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId);

            });
            modelBuilder.Entity<ItemDetails>(entity =>
            {
                entity.HasKey(e => e.ItemDtId);

            });
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

            });
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

            });
            modelBuilder.Entity<Guest>(entity =>
            {
                entity.HasKey(e => e.GuestId);

            });
            modelBuilder.Entity<Combos>(entity =>
            {
                entity.HasKey(e => e.ComboId);

            });
            modelBuilder.Entity<Carts>(entity =>
            {
                entity.HasKey(e => e.CartId);

            });
            modelBuilder.Entity<CartDetails>(entity =>
            {
                entity.HasKey(e => e.CartDtlId);

            });
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

            });
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

            });
            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderDtlId);

            });
            modelBuilder.Entity<ItemImage>(entity =>
            {
                entity.HasKey(e => e.ImageId);

            });

        }
    }
}
