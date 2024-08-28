using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]

public class LinqEj4Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get([FromQuery] List<int> numeros)
    {
        var numerosOrdenados = numeros.OrderByDescending(x => x).Take(5).ToList();
        return Ok(numerosOrdenados);
    }
}