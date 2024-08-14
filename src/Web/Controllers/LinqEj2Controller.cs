using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj2Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<string> palabras)
    {
        var resultado = from p in palabras
                       where p.Length >= 5
                       select p.ToUpper();

        resultado.ToList();

        return Ok(resultado);
    }
}