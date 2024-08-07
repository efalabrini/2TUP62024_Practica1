using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int num1, int num2)
        {
            if (num2 - num1 < 1000)
            {
                List<int> numeros = new();
                while(num1 <= num2)
                {
                    numeros.Add(num1);
                    num1 += 1;
                }
                return Ok(numeros);
            }
            else
            {
                return BadRequest("la diferencia entre el numero inicial y final debe ser menor a 1000");
            }
        }
    }
}
