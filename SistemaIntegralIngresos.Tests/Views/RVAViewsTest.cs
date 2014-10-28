using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaIntegralIngresos.Controllers;
using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;

namespace SistemaIntegralIngresos.Tests.Views
{
    [TestClass]
    [UseReporter(typeof(FileLauncherReporter))]
    public class RVAViewsTest : MvcTest
    {
        [TestMethod]
        public void IndexRVAViewTest()
        {
            MvcApprovals.VerifyMvcPage(new RVAController().Index);
        }
    }
}
