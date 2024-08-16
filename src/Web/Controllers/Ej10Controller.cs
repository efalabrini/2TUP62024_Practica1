using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int inicio, int fin)
        {
            if (fin - inicio >= 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();

            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }
                else
                {
                    numerosImpares.Add(i);
                }
            }

            var resultado = new
            {
                Pares = numerosPares,
                Impares = numerosImpares
            };

            return Ok(resultado);
        }
    }
}
