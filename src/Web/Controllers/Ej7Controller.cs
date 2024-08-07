using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej7Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] int inicio, [FromQuery] int fin)
    {
        if (fin - inicio >= 1000)
        {
            return BadRequest("La diferencioa entre inicio y fin debe ser menor a 1000");
        }
        
        List<int> numeros = new List<int>();

        for (int i = inicio; i <= fin; i++)
        {
            numeros.Add(i);
        }

        return Ok(numeros);
    }
}
