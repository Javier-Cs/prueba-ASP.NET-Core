using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaEntityFramework.Models
{
    [Table("Products", Schema = "store")]
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public DateTime DateCreated { get; set; }
        public string SKU { get; set; }
        public decimal Weight { get; set; }
        public string Dimensions { get; set; }
        public bool IsActive { get; set; }

    }
}
