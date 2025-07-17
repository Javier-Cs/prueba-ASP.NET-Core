using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaEntityFramework.Models
{
    [Table("OrderItems", Schema ="store")]
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }


        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName="decimal(10,2)")]
        public decimal Subtotal { get; set; }
    }
}