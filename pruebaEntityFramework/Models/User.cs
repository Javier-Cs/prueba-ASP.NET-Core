using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaEntityFramework.Models
{
    [Table("Users", Schema = "store")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        public DateTime RegisteredAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        // Propiedad de navegación para la relación con Orders (un usuario puede tener muchas órdenes)
        public ICollection<Order> Orders { get; set; }
    }
}
