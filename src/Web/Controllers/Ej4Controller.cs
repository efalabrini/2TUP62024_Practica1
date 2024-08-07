using Microsoft.AspNetCore.Mvc;

namespace MayorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] int num1, [FromQuery] int num2)
        {
            int mayor = (num1 > num2) ? num1 : num2;
            return Ok(mayor);
        }
    }
}
