using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej10Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] int inicio, [FromQuery] int fin)
    {
        if (fin - inicio >= 1000)
        {
            return BadRequest("La diferencioa entre inicio y fin debe ser menor a 1000");
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

        return Ok(new { Pares = numerosPares, Impares = numerosImpares });
    }
}