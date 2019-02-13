using ODataV4.DataAccess;
using System.Web.Http;
using System.Web.Http.OData;

namespace ODataV4.WebApi.Controllers
{
    public class PepoleController : ODataController
    {
        private ODataV4DbContext dbContext = new ODataV4DbContext();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(dbContext.Person);
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}
