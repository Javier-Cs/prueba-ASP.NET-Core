using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaEntityFramework.Models
{
    [Table("Orders", Schema ="store")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } // propiedad de navegacion


        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "enviado";

        [Required]
        [MaxLength(50)]
        public string PaymentMethod { get; set; }

        [Required]
        [Column(TypeName ="decimal(10,2)")]
        public decimal ShippingCost { get; set; }

        // Propiedad de navegación para la relación con OrderItems (una orden puede tener muchos ítems)
        public ICollection<OrderItem> OrderItems { get; set; }


    }
}
