using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]

public class LinqEj7Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get([FromQuery]string frase)
    {
        var palabras = frase.Split(' ');
        var palabrasMayus = palabras.Where(pal => string.Equals(pal, pal.ToUpper(), StringComparison.Ordinal)).ToList();

        return Ok(palabrasMayus);
    }
}