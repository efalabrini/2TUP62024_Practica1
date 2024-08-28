using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]

public class LinqEj1Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get(int min, int max, [FromQuery] List<int> numbers)
    {
        var numberQuery = numbers.Where(x => x >= min && x <= max).ToList();
        return Ok(numberQuery);
    }
}