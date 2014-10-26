using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaIntegralIngresos.Models;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SistemaIntegralIngresos.Tests.Controllers
{
    [TestClass]
    public class CampusControllerTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.Data.Entity.Validation.DbEntityValidationException))]
        public void TestCampusWithEmptyName()
        {
            var campus = new Campus { Id = 1, Name = "", Code = "UTGU", Details = "" };
            SIIDbContext context = new SIIDbContext();
            context.Campus.Add(campus);
            context.SaveChanges();
        }
    }
}
