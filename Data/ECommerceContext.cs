using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data
{
    public class ECommerceContext:DbContext
    {
        public ECommerceContext(DbContextOptions options):base(options)
        {

        }
        ////////////////////////////////////
        protected  override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(mb =>
            {
                mb.HasOne(f => f.OrderDetails)
                .WithOne(h => h.Order)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);
            });
            modelBuilder.Entity<OrderBillingInfo>(mb =>
            {
                mb.HasKey(k => new { k.OrderId,k.BillingInfoId});


            });


        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
         public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<PersonalInfo> PersonalInfos { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet <Order> Orders { get; set; }
        public virtual DbSet<OrderBillingInfo> OrderBillingInfos { get; set; }
        public virtual DbSet<BillingInfo> BillingInfos { get; set; }

    }
}
