using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaIntegralIngresos.Models;
using Telerik.JustMock;
using System.Collections.Generic;
using SistemaIntegralIngresos.Controllers;
using System.Web.Mvc;

namespace SistemaIntegralIngresos.Tests.Controllers
{
    [TestClass]
    public class VisitCOntrollerTest
    {
        [TestMethod]
        public void IndexReturnALlVisit()
        {
            //Arrange
            var VisitRepository = Mock.Create<Repository>();
            Mock.Arrange(() => VisitRepository.GetAllVisit() ).
                Returns( new List<Visit>()
            {
                new Visit{Id=1, FullName="test", AnnouncementId = 1, TypeEntrance ="test"},
                new Visit{Id=2, FullName="test", AnnouncementId = 1, TypeEntrance ="test"},
                new Visit{Id=3, FullName="test", AnnouncementId = 1, TypeEntrance ="test"} 
           
            }).MustBeCalled();

            //Act
            VisitController controller = new VisitController(VisitRepository);
            ViewResult viewResult = controller.IndexTest() as ViewResult;
            var model = viewResult.Model as IEnumerable<Visit>;

            //Assert 
            Assert.AreEqual(3, model.Count());
        }

       
    }
}
