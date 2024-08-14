using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj5Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<int> numeros)
    {
        var resultado = (from num in numeros
                         let cuadrado = num * num
                         where cuadrado > 20
                         select $"{num} - {cuadrado}").ToList();

        return Ok(resultado);
    }
}