using ODataV4.DataAccess;
using ODataV4.Model;
using System;
using System.Collections.Generic;
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
            //var person = new Person()
            //{
            //    DateOfBirth = new DateTimeOffset(new DateTime(1986, 3, 6)),
            //    Email = "sven@someemailprovider.com",
            //    FirstName = "Sven",
            //    LastName = "Vercauteren",
            //    Gender = Gender.Male,
            //    NumberOfRecordsOnWishList = 34,
            //    AmountOfCashToSpend = 2000
            //};

            //dbContext.Person.Add(person);
            //dbContext.SaveChanges();
            return Ok(dbContext.Person);
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}
