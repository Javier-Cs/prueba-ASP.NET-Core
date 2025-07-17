using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaEntityFramework.Models
{
    [Table("Products", Schema = "store")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        [MaxLength (100)]
        public string SKU { get; set; }

        [Required]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Weight { get; set; }

        [Required]
        [MaxLength (200)]
        public string Dimensions { get; set; }

        public bool IsActive { get; set; } = true;

        // claves foraneas 
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } // Propiedad de navegación

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; } // Propiedad de navegación

        // Propiedades de navegación para relaciones uno a uno y uno a muchos
        public Inventory inventory { get; set; } // Relación uno a uno con Inventory
        public ICollection<OrderItem> OrdersItems { get; set; } // Un producto puede estar en muchos OrderItems

    }
}
