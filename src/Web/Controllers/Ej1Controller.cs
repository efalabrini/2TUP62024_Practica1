using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej1Controller : ControllerBase
    {

        [HttpGet]
        public IActionResult Get([FromQuery] int num1, [FromQuery] int num2, [FromQuery] int num3)
        {
            int suma = num1 + num2 + num3;
            return Ok(suma);
        }
    }
}
