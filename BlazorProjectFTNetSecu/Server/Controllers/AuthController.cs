using BlazorProjectFTNetSecu.Server.Context;
using BlazorProjectFTNetSecu.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorProjectFTNetSecu.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost("Login")]// => Auth/Login
        public ActionResult<string> Login(LoginAuthForm loginAuthForm)
        {

            AuthUser? user = FakeDB.Users.FirstOrDefault(u => u.Email == loginAuthForm.Email, null);

            if (user == null)
            {
                return Unauthorized();
            }

            if (user.Password == loginAuthForm.Password) 
            {
                return Ok(user.SecretMessage);
            }

            return Unauthorized();

        }

        [HttpPost("Register")] // => Auth/Register
        public IActionResult Register(AuthUser newUser)
        {

            FakeDB.Users.Add(newUser);

            return NoContent();
        }


    }
}
