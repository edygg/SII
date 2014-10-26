using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaIntegralIngresos;
using SistemaIntegralIngresos.Controllers;
using Telerik.JustMock;
using SistemaIntegralIngresos.Models;

namespace SistemaIntegralIngresos.Tests.Controllers
{
    [TestClass]
    public class CampusControllerTest
    {
        [TestMethod]
        public void TestIndex()
        {
            //Arrange
            var campusRepository = Mock.Create<Repository>();
            Mock.Arrange(() => campusRepository.GetAllCampus()).
                Returns(new List<Campus>()
            {
                new Campus{Id=1, Code="test1", Details="test1", Name="test1"},
                new Campus{Id=2, Code="test2", Details="test2", Name="test2"}

            }).MustBeCalled();

            //Act
            CampusController controller = new CampusController(campusRepository);
            ViewResult viewResult = controller.IndexForTest() as ViewResult;
            var model = viewResult.Model as IEnumerable<Campus>;
            
            //Assert 
            Assert.AreEqual(2, model.Count() );
        }

        [TestMethod]
        public void testDetails()
        {
            //Arrange
            var campusRepository = Mock.Create<Repository>();
            Mock.Arrange(() => campusRepository.GetAllCampus()).
                Returns(new List<Campus>()
            {
                new Campus{Id=1, Code="test1", Details="test1", Name="test1"},
                new Campus{Id=2, Code="test2", Details="test2", Name="test2"}

            }).MustBeCalled();

            //Act
            CampusController controller = new CampusController(campusRepository);
            ViewResult viewResult = controller.TestingDetails(1) as ViewResult;
            var model = viewResult.Model as Campus;

            //Assert 
            Assert.AreEqual(1, model.Id);
        }
    }
  
}
