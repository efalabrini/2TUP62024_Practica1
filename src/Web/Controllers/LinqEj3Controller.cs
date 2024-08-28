using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]

public class LinqEj3Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get([FromQuery] List<string> palabras)
    {
        var nuevaListaPalabras = palabras.Where(x => x.StartsWith('b') && x.EndsWith('r')).ToList();
        return Ok(nuevaListaPalabras);
    }
}