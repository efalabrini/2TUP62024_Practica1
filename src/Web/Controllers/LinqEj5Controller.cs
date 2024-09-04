using Microsoft.AspNetCore.Mvc;
using System.Linq;

/* 
5) Reciba una lista de números enteros y retorne una lista de sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20.
Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”
*/

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class LinqEj5Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get([FromQuery] List<int> numeros)
    {
        var numerosCuadrado = numeros
        .Select(num => new {Numero = num, Cuadrado = num * num})
        .Where(x => x.Cuadrado > 20)
        .Select(x => $"{x.Numero} - {x.Cuadrado}")
        .ToList();

        return Ok(numerosCuadrado);
    }
}