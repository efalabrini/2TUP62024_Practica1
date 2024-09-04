using Microsoft.AspNetCore.Mvc;
using System.Linq;

/* 
3) Reciba una lista de palabras y retorne las que empiezan por la letra "b" y terminan con la letra "r".
Ejemplo: "ventilador", "reloj", "buscador" → "buscador"
*/

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class LinqEj3Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get([FromQuery] List<string> palabras)
    {
        // validamos que empiece con 'b' con StartsWith
        // validamos que termine con 'r' con EndsWith
        var listaPalabras = palabras.Where(x => x.StartsWith('b') && x.EndsWith('r')).ToList();
        return Ok(listaPalabras);
    }
}