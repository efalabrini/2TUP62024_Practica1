using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej7controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int inicio, int fin)
    {
        if ((fin - inicio) >= 1000)
        {
            return BadRequest("La diferencia entre los numeros debe ser menor que 1000");
        }
        
        var numeros = new List<int>();

        for (int i = inicio; i <= fin; i++)
        {
            numeros.Add(i);
        }
        return Ok(numeros);
    }
}