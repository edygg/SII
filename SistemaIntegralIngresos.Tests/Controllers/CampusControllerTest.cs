using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaIntegralIngresos.Controllers;

namespace SistemaIntegralIngresos.Tests.Controllers
{
    [TestClass]
    public class CampusControllerTest
    {
        [TestMethod]
        public void TestIndexView()
        {
            var controller = new CampusController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
