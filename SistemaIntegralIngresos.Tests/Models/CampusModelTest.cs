using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaIntegralIngresos.Models;

namespace SistemaIntegralIngresos.Tests.Controllers
{
    [TestClass]
    public class CampusModelTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.Data.Entity.Validation.DbEntityValidationException))]
        public void TestCampusRequiredCode()
        {
            var campus = new Campus { Id = 1, Code = "", Name = "Universidad", Details = "" };
            SIIDbContext context = new SIIDbContext();
            context.Campus.Add(campus);
            context.SaveChanges();
            context.Dispose();
        }

        [TestMethod]
        [ExpectedException(typeof(System.Data.Entity.Validation.DbEntityValidationException))]
        public void TestCampusRequiredName()
        {
            var campus = new Campus { Id = 1, Code = "Code", Name = "", Details = "" };
            SIIDbContext context = new SIIDbContext();
            context.Campus.Add(campus);
            context.SaveChanges();
            context.Dispose();
        }

    }
}
