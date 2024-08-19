using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej8controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int inicio, int fin)
    {
        if ((fin - inicio) >= 1000)
        {
            return BadRequest("La diferencia entre los numeros debe ser menor que 1000");
        }
        
        var numeros = new List<int>();
        var start = inicio;

        while (start <= fin)
        {
            numeros.Add(start);
            start++;
        }
        return Ok(numeros);
    }
}