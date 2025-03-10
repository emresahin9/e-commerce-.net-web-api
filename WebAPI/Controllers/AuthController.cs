using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult LoginAdmin(LoginDto loginDto)
        {
            var adminLogin = _authService.LoginAdmin(loginDto);
            if (!adminLogin.Success)
            {
                return BadRequest(adminLogin.Message);
            }

            var result = _authService.CreateAccessTokenForAdmin(adminLogin.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
