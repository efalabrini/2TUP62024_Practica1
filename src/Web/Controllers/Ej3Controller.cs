using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string nombre, int edad)
        {
            string message = $"Te llamas {nombre}, y tienes {edad} años.";
            return Ok(message);
        }
    }
}
