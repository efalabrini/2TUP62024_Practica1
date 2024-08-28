using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]

public class LinqEj2Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get([FromQuery] List<string> palabras)
    {
        var palabrasQuery = palabras
            .Where(x => x.Length >= 5)
            .Select(x => x.ToUpper())
            .ToList();

        return Ok(palabrasQuery);
    }
}