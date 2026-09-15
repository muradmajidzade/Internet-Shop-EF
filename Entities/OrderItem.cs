using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet_Shop.Entities
{
    [Table("OrderItems")]
    public class OrderItem
    {
        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; } // Цена хранится одновременно и в Product и в OrderItem для того чтобы при изменении цены в Product цена уже заказанного товара которая хранится в UnitPrice не менялась
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}