using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaEntityFramework.Models
{
    // establecemos una tabla con su esquema
    [Table("Categories", Schema = "store")]
    public class Category
    {
        // marca a categoriaID como llave primaria
        [Key]
        public int CategoryId { get; set; }

        // se marca como un mercado requerido
        [Required]
        // defina la longitud maxima del nombre
        [MaxLength(70)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<Product> productos { get; set; }
    }
}
