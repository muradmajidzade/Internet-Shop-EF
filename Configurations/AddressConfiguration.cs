using Internet_Shop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internet_Shop.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasOne(a => a.User)
                   .WithOne(u => u.Address)
                   .HasForeignKey<Address>(a => a.UserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}