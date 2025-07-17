using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaEntityFramework.Models
{
    [Table("Inventory", Schema ="store")]
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }


        public int Stock { get; set; }

        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}