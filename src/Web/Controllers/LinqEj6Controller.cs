using Microsoft.AspNetCore.Mvc;
using System.Linq;

/* 
6) Reciba una lista de palabras y  retorne una lista que sustituya la cadena 'ia' por el asterisco (*) en cada palabra dada. Para simplificar escribir todo sin acento.
Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"
*/

namespace Web;

[ApiController]
[Route("[controller]")]

public class LinqEj6Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get([FromQuery] List<string> palabras)
    {
        var nuevasPalabras = palabras.Select(pal => pal.Replace("ia", "*")).ToList();
        return Ok(nuevasPalabras);
    }
}