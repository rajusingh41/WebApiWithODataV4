using System.ComponentModel.DataAnnotations;

namespace ODataV4.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(150)]
        public string CatalogNumber { get; set; }

        public int? Year { get; set; }

        public ProductDetail ProductDetail { get; set; }

        public virtual Person Person { get; set; }

    }
}
