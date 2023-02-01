using BLL.Services;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _service;
        public AuthenticationController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("Login")]
        public IActionResult Login(int userId)
        {
            return Ok(_service.GetUserById(userId));

        }
    }
}
