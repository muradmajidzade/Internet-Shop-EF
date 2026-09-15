using Internet_Shop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internet_Shop.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(o => o.User)
                   .WithMany(u => u.Orders)
                   .HasForeignKey(o => o.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Order_TotalAmount", "TotalAmount >= 0");
                t.HasCheckConstraint("CK_Order_Status", "Status = 'Pending' OR Status = 'Paid' OR Status = 'Shipped' OR Status = 'Delivered' OR Status = 'Cancelled'");
            });
        }
    }
}