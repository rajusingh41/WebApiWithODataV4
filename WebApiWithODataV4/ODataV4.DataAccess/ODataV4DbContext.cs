using ODataV4.Model;
using System.Data.Entity;
namespace ODataV4.DataAccess
{
    public class ODataV4DbContext:DbContext
    {
        public ODataV4DbContext() : base("name=ODataV4Connection")
        {
            Database.SetInitializer(new ODataV4DbInitializer());

            // disable lazy loading 
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Person> Person { get; set; }

        public DbSet<Product> Products { get; set; }
        
        public DbSet<Store> Stores { get; set; }

        public DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
