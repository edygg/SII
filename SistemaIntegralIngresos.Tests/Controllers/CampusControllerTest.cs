using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using SistemaIntegralIngresos.Models;
using System.Collections.Generic;

namespace SistemaIntegralIngresos.Tests.Controllers
{
    [TestClass]
    public class CampusControllerTest
    {
        [TestMethod]
        public void TestIndex()
        {
            //Arrange
            var model = Mock.Create<Repository>();
            Mock.Arrange(() => model.GetAllCampus()).
                Returns(new List<Campus>()
            {
                new Campus{Id=1, Code="test1", Details="test1", Name="test1"},
                new Campus{Id=1, Code="test1", Details="test1", Name="test1"}

            }).MustBeCalled();

        }
    }
}
