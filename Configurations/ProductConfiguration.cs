using Internet_Shop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internet_Shop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(p => p.Category)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Product_Price", "Price > 0");
                t.HasCheckConstraint("CK_Product_StockQuantity", "StockQuantity >= 0");
            });

            builder.HasIndex(p => p.Name); // Без Unique так как в разных категориях может быть продукт с одним именем

            builder.HasIndex(p => new { p.CategoryId, p.Name })
                   .IsUnique(); // Unique так как в одной категории не может быть двух продуктов с одинаковым именем
        }
    }
}