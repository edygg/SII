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
        public void GetAllCampus()
        {
            //Arrange
            var campusRepository = Mock.Create<ICampus>();
            Mock.Arrange(() => campusRepository.GetAllCampus()).
                Returns(new List<Campus>()
            {
                new Campus{Id=1, Code="test1", Details="test1", Name="test1"},
                new Campus{Id=2, Code="test2", Details="test2", Name="test2"}

            }).MustBeCalled();

            //Act
            CampusController controller = new CampusController(campusRepository);
            ViewResult viewResult = controller.GetAllCampus() as ViewResult;
            var model = viewResult.Model as IEnumerable<Campus>;
            
            //Assert 
            Assert.AreEqual(2, model.Count() );
        }

        [TestMethod]
        public void CreateCampus()
        {
            
           //Arrange
            Campus campus = new Campus {Code = "test2", Details = "test2", Name = "test2" };
            var mockRepo =  Mock.Create<ICampus>();
              Mock.Arrange(() => mockRepo.InsertCampus(campus)).Returns(true);
                      
            //Act
              CampusController controller = new CampusController(mockRepo);
              var viewResult = controller.InsertCampus(campus);
            
             //Assert
            Assert.AreEqual(true, viewResult);
            
        }

        [TestMethod]
        public void Delete()
        {
            //Arrange
            //Campus campus = new Campus { Id = 1 , Code = "test2", Details = "test2", Name = "test2" };
            var mockRepo = Mock.Create<ICampus>();
            //Mock.Arrange(() => mockRepo.InsertCampus(campus)).Returns(true);
            Mock.Arrange(() => mockRepo.DeleteCampus( 1) ).Returns(true);

            //Act
            CampusController controller = new CampusController(mockRepo);
            var viewResult = controller.DeleteCampus( 1 );

            //Assert
            Assert.AreEqual(true, viewResult);
        }

        [TestMethod]
        public void FindByID()
        {
            //Arrange
            var mockRepo = Mock.Create<ICampus>();
            Mock.Arrange(() => mockRepo.FindByID(1));

            //Act
            CampusController controller = new CampusController();
            var viewResult = controller.FindByID(1) as Campus;

            //Assert
            Assert.AreEqual("UNITEC Tegucigalpa", viewResult.Name);
        }

        [TestMethod]
        public void EditCampus()
        {
            //Arrange
            Campus campus = new Campus { Id = 1, Name = "UNITEC Tegucigalpa", Details = "", Code = "UTGU" };
            var mockRepo = Mock.Create<ICampus>();
            Mock.Arrange(() => mockRepo.EditCampus(campus)).Returns(true);

            //Act
            CampusController controller = new CampusController();
            var viewResult = controller.EditCampus(campus);

            //Assert
            Assert.AreEqual(true, viewResult);
        }


    }
  
}
