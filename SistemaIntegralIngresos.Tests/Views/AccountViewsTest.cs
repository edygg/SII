using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApprovalTests.Asp.Mvc;
using SistemaIntegralIngresos.Controllers;
using ApprovalTests.Reporters;

namespace SistemaIntegralIngresos.Tests.Views
{
    [TestClass]
    [UseReporter(typeof(FileLauncherReporter))]
    public class AccountViewsTest : MvcTest
    {
        [TestMethod]
        public void RegisterAccountViewTest()
        {
            MvcApprovals.VerifyMvcPage(new AccountController().Register);
        }

    }
}
