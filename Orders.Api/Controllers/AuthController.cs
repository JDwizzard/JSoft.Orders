using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orders.Api.Services;

namespace Orders.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet(Name = "GetTest")]
        public string Get()
        {
            return "Hello World";
        }

        /*
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] string lastName)
        {
            var result = _authService.Login(lastName);

            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            if (result == false)
            {
                return StatusCode(StatusCodes.Status401Unauthorized);
            }

            return StatusCode(StatusCodes.Status200OK);
        }
        */
    }
}
