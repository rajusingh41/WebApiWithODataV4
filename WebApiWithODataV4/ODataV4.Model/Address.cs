using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataV4.Model
{
    [ComplexType]
   public class Address
    {
        [StringLength(200)]
        public string Street { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(6)]
        public string PinCode { get; set; }
        [StringLength(100)]
        public string Country { get; set; }
    }
}
