using Microsoft.AspNetCore.Mvc;

namespace TraderVoyages.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        [HttpGet("Move")]
        public IActionResult Move()
        {

            return Ok();
        }
    }
}