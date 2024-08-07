using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej9Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int num1, int num2)
        {
            if (num2 - num1 < 1000)
            {
                List<int> numerosPar = new();
                for (int i = num1; i <= num2;)
                {
                    if(i % 2 == 0)
                    {
                        numerosPar.Add(i);
                    }
                    i++;
                }
                return Ok(numerosPar);
            }
            else
            {
                return BadRequest("la diferencia entre el numero inicial y final debe ser menor a 1000");
            }
        }
    }
}
