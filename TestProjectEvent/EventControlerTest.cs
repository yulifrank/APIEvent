using Microsoft.AspNetCore.Mvc;
using myFirstApiYaelFrank;
using myFirstApiYaelFrank.Controllers;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http.Results;
using BadRequestResult = System.Web.Http.Results.BadRequestResult;
using NotFoundResult = Microsoft.AspNetCore.Mvc.NotFoundResult;
using UnauthorizedResult = System.Web.Http.Results.UnauthorizedResult;

namespace TestProjectEvent
{
    public class EventControlerTest
    {
        [Fact]

        public void Get_ReturnOk()
        {

            var controller = new EventsController();
            var result = controller.Get();

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_ReturnNotFound()
        {

            int id = 5;


            var controller = new EventsController();
            var result = controller.Get(id);

            Assert.IsType<NotFoundResult>(result);
        }



        [Fact]
        public void Post_ReturnBadRequest()
        {
            // Arrange
            var controller = new EventsController();
            var invalidEvent = new Event(); // Create an invalid event object here

            // Act
            var result = controller.Post(invalidEvent);
            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void Put_ReturnInternalServerError()
        {
            // Arrange
            var controller = new EventsController();
            var invalidId = -1; // Provide an invalid ID here
            var updatedEvent = new Event(); // Provide a valid event object here

            // Act
            var result = controller.Put(invalidId, updatedEvent);

            // Assert
            Assert.IsType<InternalServerErrorResult>(result);
        }//500

        [Fact]
        public void Delete_ReturnUnauthorized()//401 
        {
            // Arrange
            var controller = new EventsController();
            var unauthorizedId = 1; // Provide a valid ID here
            // Act
            var result = controller.Delete(unauthorizedId);
            // Assert
            Assert.IsType<UnauthorizedResult>(result);
        }

    }



}