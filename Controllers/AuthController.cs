using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserManagementAPI.DTOs;
using UserManagementAPI.Services;


namespace UserManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var token = await _authService.Authenticate(loginDto);

            if (token == null) 
            {
                return Unauthorized("Email ou senha inválidos.");
            }

            return Ok(new { Token = token });
        }

    }
}
