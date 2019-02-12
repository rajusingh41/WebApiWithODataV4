using System.ComponentModel.DataAnnotations;

namespace ODataV4.Model
{
    public class ProductDetail
    {
        [Key]
        public int ProductDetailId { get; set; }
        [Required]
        [StringLength(10)]
        public string Model { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }
    }
}
