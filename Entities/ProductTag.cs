using System.ComponentModel.DataAnnotations;

namespace Internet_Shop.Entities
{
    public class ProductTag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int TagId { get; set; }

        public Product Product { get; set; }
        public Tag Tag { get; set; }

    }
}
