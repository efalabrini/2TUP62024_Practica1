using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

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