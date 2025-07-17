using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaEntityFramework.Models
{
    [Table("Brands", Schema ="store")]
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        // Propiedad de navegación para la relación con Products (una marca puede tener muchos productos)
        public ICollection<Product> Products { get; set; }
    }
}
