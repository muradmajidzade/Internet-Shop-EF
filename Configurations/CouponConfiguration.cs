using Internet_Shop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internet_Shop.Configurations
{
    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.HasMany(c => c.Orders)
                   .WithOne(o => o.Coupon)
                   .HasForeignKey(o => o.CouponId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(c => c.Code)
                   .IsUnique();

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Coupon_DiscountPercent", "DiscountPercent >= 1 AND DiscountPercent <= 100");
            });
        }
    }
}
