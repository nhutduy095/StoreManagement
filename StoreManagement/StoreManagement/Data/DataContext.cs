using Microsoft.EntityFrameworkCore;
using StoreManagement.Models;
using System.Reflection.Metadata;
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
        public DbSet<ItemMenu> ItemMenus { get; set; }
        public DbSet<ItemMenuDetail> ItemMenuDtls { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Combos> Combos { get; set; }
        public DbSet<ComboItem> ComboItems { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<UserInfoMation> UserInfoMations { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasKey(e=>e.CategoryId);
            modelBuilder.Entity<Items>().HasKey(e => e.ItemId);
            modelBuilder.Entity<Items>()
            .HasOne(i => i.Category)
            .WithMany(c => c.Items)
            .HasForeignKey(i => i.CategoryId);
            //.HasConstraintName("FK_Items_Categories_001_001_001");

            modelBuilder.Entity<Customers>().HasKey(e => e.CustomerId);
            modelBuilder.Entity<Guest>().HasKey(e => e.GuestId);
            modelBuilder.Entity<Carts>().HasKey(e => e.CartId);
            modelBuilder.Entity<CartDetails>().HasKey(e => e.CartDtlId);
            modelBuilder.Entity<Carts>()
            .HasOne<Customers>()
            .WithMany()
            .HasForeignKey(c => c.CustomerId);
            //.HasConstraintName("FK_Carts_Customers_001_001_001");
            modelBuilder.Entity<CartDetails>()
            .HasOne<Carts>()
            .WithMany()
            .HasForeignKey(cd => cd.CartId);
            //.HasConstraintName("FK_CartDetails_Carts_001_001_001");
            modelBuilder.Entity<CartDetails>()
            .HasOne<Items>()
            .WithMany()
            .HasForeignKey(cd => cd.ItemId);
            //.HasConstraintName("FK_CartDetails_Items_001_001_001");
            modelBuilder.Entity<Carts>()
             .HasOne<Guest>()
             .WithMany()
             //.HasForeignKey(c => c.GuestId)
             ;
             //FK_Carts_Customers_CustomerId1"FK_Carts_Guests_001_001_001");

            modelBuilder.Entity<ItemDetails>().HasKey(e => e.ItemDtId);
            modelBuilder.Entity<ItemMenu>().HasKey(e=>e.Id);
            modelBuilder.Entity<ItemMenuDetail>().HasKey(e => e.Id);
            modelBuilder.Entity<ItemImage>().HasKey(e => e.ImageId);
            modelBuilder.Entity<ItemImage>()
            .HasOne(ii => ii.Item)
            .WithMany(i => i.ItemImages);
            //.HasForeignKey(ii => ii.ItemId);
            //.HasConstraintName("FK_ItemImage_Items_001_001");
            modelBuilder.Entity<ItemMenuDetail>()
            .HasOne<ItemMenu>()
            .WithMany();
            //.HasForeignKey(imd => imd.ItemMenuId);
            //.HasConstraintName("FK_ItemMenuDetail_ItemMenu_001_001");
            //.HasConstraintName("FK_ItemMenuDetail_ItemMenu_001_001");
            modelBuilder.Entity<ItemMenuDetail>()
            .HasOne<Items>()
            .WithMany(i => i.ItemMenuDetails);
            //.HasForeignKey(imd => imd.ItemId);
            //.HasConstraintName("FK_ItemMenuDetail_Items_001_001");
            modelBuilder.Entity<ItemDetails>()
            .HasOne(id => id.Item)
            .WithMany(i => i.ItemDetails);
            //.HasForeignKey(id => id.ItemId);
            //.HasConstraintName("FK_ItemDetails_Items_001_001");

            modelBuilder.Entity<Combos>().HasKey(e => e.ComboId);
            modelBuilder.Entity<ComboItem>()
            .HasKey(ci =>ci.ComboDtlId);
            modelBuilder.Entity<ComboItem>()
            .HasOne(ci => ci.Combo)
            .WithMany(c => c.ComboItems);
            //.HasForeignKey(ci => ci.ComboId);
            //.HasConstraintName("FK_ComboItem_Combos_001_001");
            modelBuilder.Entity<ComboItem>()
                .HasOne(ci => ci.Item)
                .WithMany(i => i.ComboItems);
                //.HasForeignKey(ci => ci.ItemId);
                //.HasConstraintName("FK_ComboItem_Items_001_001");

            modelBuilder.Entity<Users>().HasKey(e => e.UserId);
            modelBuilder.Entity<UserInfoMation>().HasKey(e => e.UserId);
            modelBuilder.Entity<Orders>().HasKey(e => e.OrderId);
            modelBuilder.Entity<OrderDetails>().HasKey(e => e.OrderDtlId);
            modelBuilder.Entity<Orders>()
            .HasOne(o => o.Guest)
            .WithMany(g => g.Orders);
            //.HasForeignKey(o => o.GuestId);
            //.HasConstraintName("FK_Orders_GuestId_001");
            modelBuilder.Entity<Orders>()
            .HasOne(o => o.Customers)
            .WithMany(g => g.Orders);
            //.HasForeignKey(o => o.CustomerId);
            //.HasConstraintName("FK_Orders_CustomerId_001");
            modelBuilder.Entity<OrderDetails>()
            .HasOne(od => od.Order)
            .WithMany(o => o.OrderDetails);
            //.HasForeignKey(od => od.OrderId);
            //.HasConstraintName("FK_OrderDetails_Orders_001");
            modelBuilder.Entity<OrderDetails>()
            .HasOne(od => od.ItemMenu)
            .WithMany(im => im.OrderDetails);
            //.HasForeignKey(od => od.ItemMenuId);
            //.HasConstraintName("FK_OrderDetails_ItemMenu_001");
        }
    }
}
