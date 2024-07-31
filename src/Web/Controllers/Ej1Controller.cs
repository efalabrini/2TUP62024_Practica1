using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get( int a,  int b, int c)
        {
            int sum = a + b + c;
            return Ok("El resultado es " + sum);
        }
    }
}
