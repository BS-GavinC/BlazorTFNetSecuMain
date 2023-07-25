using BlazorProjectFTNetSecu.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorProjectFTNetSecu.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> Get()
        {
            Console.WriteLine("Endpoint Get Hit");
            return Ok("Reponse du Get");
        }

        [HttpPost]
        public ActionResult<User> Post(RegisterForm registerForm)
        {
            Console.WriteLine("Endpoint Post Hit");
            User user = new User(registerForm.Lastname, registerForm.Email, registerForm.Password);
            return Ok(user);
        }
    }
}
