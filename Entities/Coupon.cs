using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet_Shop.Entities
{
    [Table("Coupons")]
    public class Coupon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Code { get; set; }

        [Required]
        public int DiscountPercent { get; set; }

        [Required]
        public DateTime ExpiresAt { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}