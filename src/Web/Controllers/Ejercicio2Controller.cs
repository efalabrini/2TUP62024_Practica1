using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string? name = null, [FromQuery] string? city = null)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(city))
            {
                return BadRequest("Please make sure name and city are not empty");
            }

            var message = $"Hola {name.Trim()}, bienvenido a {city.Trim()}.";
            return Ok(message);
        }
    }
}