using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataV4.Model
{
    public class Store
    {
        public Store()
        {
            Tags = new List<string>();
            Ratings = new List<Rating>();
            StoreAddress = new Address();
        }
        [Key]
        public int StoreId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Address StoreAddress { get; set; }

        public ICollection<string> Tags { get; set; }

        public ICollection<Rating> Ratings { get; set; }



    }
}
