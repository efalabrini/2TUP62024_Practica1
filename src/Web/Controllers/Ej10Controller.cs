using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int num1, int num2)
        {
            if(num2 - num1 < 1000)
            {
                List<int> numerosPar = new();
                List<int> numerosImpar = new();
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 == 0)
                    {
                        numerosPar.Add(i);
                    }
                    else
                    {
                        numerosImpar.Add(i);
                    }
                }
                var resultado = new
                {
                    Pares = numerosPar,
                    Impares = numerosImpar
                };

                return Ok(resultado);
            }
            else
            {
                return BadRequest("no puede haber 1000 numeros de diferencia entre numero inicial y final");
            }
        }
    }
}
