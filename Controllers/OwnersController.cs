using Microsoft.AspNetCore.Mvc;
using CNGFinder.Models;
using CNGFinder.Services;
using Microsoft.AspNetCore.Identity.Data;

namespace CNGFinder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnersController : ControllerBase
    {
        private readonly IOwerService _ownerService;

        public OwnersController(IOwerService owerService)
        {
            _ownerService = owerService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Owner owner)
        {
            try
            {
                var result = await _ownerService.RegisterOwner(owner);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                var result = await _ownerService.LoginOwner(request.Email, request.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
