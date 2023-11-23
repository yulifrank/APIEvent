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
        private readonly EventsController _eventsController;

        public EventControlerTest()
        {
            var context = new DataContextFake();
            _eventsController = new EventsController(context);
        }
        [Fact]
        public void Get_ReturnOk()
        {
            var result = _eventsController.Get();
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetById_ReturnNotFound()
        {
            int id = 5;
            var result = _eventsController.Get(id);
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void Post_ReturnBadRequest()
        {
            // Arrange
            var invalidEvent = new Event(); // Create an invalid event object here
            // Act
            var result = _eventsController.Post(invalidEvent);
            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void Put_ReturnInternalServerError()
        {
            // Arrange
            var invalidId = -1; // Provide an invalid ID here
            var updatedEvent = new Event(); // Provide a valid event object here

            // Act
            var result = _eventsController.Put(invalidId, updatedEvent);

            // Assert
            Assert.IsType<InternalServerErrorResult>(result);
        }//500

        [Fact]
        public void Delete_ReturnUnauthorized()//401 
        {
            // Arrange
            var unauthorizedId = 1; // Provide a valid ID here
            // Act
            var result = _eventsController.Delete(unauthorizedId);
            // Assert
            Assert.IsType<UnauthorizedResult>(result);
        }

    }



}