using Microsoft.AspNetCore.Mvc;
using System.Linq;

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