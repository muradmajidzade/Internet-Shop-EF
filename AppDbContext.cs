using Internet_Shop.Entities;
using Microsoft.EntityFrameworkCore;

namespace Internet_Shop
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Coupon> Coupons { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = localhost; Database = Internet Shop; Trusted_Connection = True; TrustServerCertificate = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
