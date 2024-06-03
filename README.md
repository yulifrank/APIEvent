# APIEvent
1. Get_ReturnOk:
This function checks the Get() function in the EventsController class and ensures that the result it returns is of type OkObjectResult. This means that the test will pass if when the Get() function is called, it returns an OkObjectResult.

2. GetById_ReturnNotFound:
This function checks the Get(int id) function in the EventsController class and ensures that the result it returns is of type NotFoundResult. This means that the test will pass if when the Get(int id) function is called with an existing id, it returns a NotFoundResult.

3. Post_ReturnBadRequest:
This function checks the Post() function in the EventsController class. It first creates a new instance of EventsController and an invalidEvent object, representing an invalid event. Then, it calls the Post() function with the invalidEvent as an argument. After that, the function asserts that the result returned by the Post() function is of type BadRequestResult. This implies that the test will pass if the Post() function returns a BadRequestResult.

4. Put_ReturnInternalServerError:
This function checks the Put() function in the EventsController class. It creates a new instance of EventsController, defines an invalidId variable (representing an invalid id), and an updatedEvent object (representing a valid event). Then, the function calls the Put() function with the invalidId and updatedEvent as arguments. It asserts that the result returned by the Put() function is of type InternalServerErrorResult. The test will pass if the Put() function returns an InternalServerErrorResult.

5. Delete_ReturnUnauthorized:
This function checks the Delete() function in the EventsController class. It creates a new instance of EventsController and defines an unauthorizedId variable (representing a valid id). Then, the function calls the Delete() function with the unauthorizedId as an argument. It asserts that the result returned by the Delete() function is of type UnauthorizedResult. The test will pass if the Delete() function returns an UnauthorizedResult.
