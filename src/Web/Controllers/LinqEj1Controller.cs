using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj1Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<int> numeros, [FromQuery] int min, [FromQuery] int max)
    {
        var numQuery = from num in numeros
                       where num >= min && num <= max
                       select num;

        numQuery.ToList();

        return Ok(numQuery);
    }
}