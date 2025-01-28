using Microsoft.AspNetCore.Mvc;

namespace beautysalon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {

        private readonly ILogger<AuthenticationController> _logger;

        public AuthenticationController(ILogger<AuthenticationController> logger)
        {
            _logger = logger;
        }

        [HttpPost("")]
       public async Task<IActionResult> RegisterAsync ()
        {
            return Ok("");
        }
    }
}
