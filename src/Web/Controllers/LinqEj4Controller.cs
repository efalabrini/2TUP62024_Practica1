using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj4Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<int> numeros)
    {
        var resultado = (from num in numeros
                        orderby num descending
                        select num).Take(5).ToList();

        return Ok(resultado);
    }
}