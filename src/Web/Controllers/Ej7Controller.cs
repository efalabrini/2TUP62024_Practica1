using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int num1, int num2)
        {
            List<int> numeros = new List<int>();
            if (num2 - num1 < 1000)
            {
                for (int i = num1; i <= num2; i++)
                {
                    numeros.Add(i);
                }
                return Ok(numeros);
            }
            else
            {
                return BadRequest("no puede haber mas de 1000 numeros de diferencia entre numero inicial y final");
            }
        }
    }
}
