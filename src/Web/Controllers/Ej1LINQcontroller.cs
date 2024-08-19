using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej1LINQcontroller : ControllerBase
{
    [HttpGet]
    public IActionResult Get( [FromQuery] List<int> numeros)
    {
        var numQuery = 
            from num in numeros
            where num > 30 && num < 100
            select num;
            
        numQuery.ToList();

        return Ok(numQuery);

    }
}