using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj3Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<string> palabras)
    {
        var resultado = from p in palabras
                        where p.StartsWith("b") && p.EndsWith("r")
                        select p;

        resultado.ToList();

        return Ok(resultado);
    }
}