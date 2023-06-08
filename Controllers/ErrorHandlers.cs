using employeTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace employeTracker.Controllers
{
    [ApiController]
    public class ErrorHandlersController : ControllerBase
    {
        // 500 Internal Server Error handler
        [HttpGet]
        [Route("error/internalservererror")]
        public IActionResult InternalServerError()
        {
            var errorResponse = new ErrorResponse
            {
                ErrorCode = 500,
                ErrorMessage = "Internal Server Error"
            };
            return new ObjectResult(errorResponse)
            {
                StatusCode = 500
            };
        }

        // 400 Bad Request handler
        [HttpGet]
        [Route("error/badrequest")]
        public IActionResult BadRequest(string errorMessage)
        {
            var errorResponse = new ErrorResponse
            {
                ErrorCode = 400,
                ErrorMessage = errorMessage
            };
            return new ObjectResult(errorResponse)
            {
                StatusCode = 400
            };
        }

        // 404 Not Found handler
        [HttpGet]
        [Route("error/notfound")]
        public IActionResult NotFound()
        {
            var errorResponse = new ErrorResponse
            {
                ErrorCode = 404,
                ErrorMessage = "Resource not found"
            };
            return new ObjectResult(errorResponse)
            {
                StatusCode = 404
            };
        }
    }
}
