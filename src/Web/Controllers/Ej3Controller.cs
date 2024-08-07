using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio3Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string? name = null, [FromQuery] int age = 0)
        {

            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("Please make sure name is not empty");
            }
            if (age < 0)
            {
                return BadRequest("Age cannot be negative");
            }
            if (age > 120)
            {
                return BadRequest("Age cannot be greater than 120");
            }

            var message = $"Te llamas {name.Trim()}, y tienes {age} años.";
            return Ok(message);
        }
    }
}

