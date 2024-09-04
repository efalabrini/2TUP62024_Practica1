using Microsoft.AspNetCore.Mvc;
using System.Linq;

/* 
7) Reciba una cadena de texto y retorne una lista con las palabras que están completamente en mayúsculas.
Ejemplo: "ESTO es un EJEMPLO del EJERcicio" → ESTO, EJEMPLO
*/

namespace Web.Controllers;

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