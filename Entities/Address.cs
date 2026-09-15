using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet_Shop.Entities
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(200)]
        public string Street { get; set; }

        [Required]
        [MaxLength(20)]
        public string House { get; set; }

        [MaxLength(20)]
        public string Apartment { get; set; }

        [Required]
        [MaxLength(20)]
        public string PostalCode { get; set; }

        public User User { get; set; }
    }
}