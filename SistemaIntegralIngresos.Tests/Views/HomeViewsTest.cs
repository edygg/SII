using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApprovalTests.Reporters;
using SistemaIntegralIngresos.Controllers;
using ApprovalTests.Asp.Mvc;

namespace SistemaIntegralIngresos.Tests.Views
{
    [TestClass]
    [UseReporter(typeof(FileLauncherReporter))]
    public class HomeViewsTest : MvcTest
    {
        [TestMethod]
        public void IndexHomeViewTest()
        {
            MvcApprovals.VerifyMvcPage(new HomeController().Index);
        }

        [TestMethod]
        public void ContactHomeViewTest()
        {
            MvcApprovals.VerifyMvcPage(new HomeController().Contact);
        }

        [TestMethod]
        public void AboutHomeViewTest()
        {
            MvcApprovals.VerifyMvcPage(new HomeController().About);
        }
    }
}
