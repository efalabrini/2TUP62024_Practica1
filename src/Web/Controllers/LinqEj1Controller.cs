using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj1Controller : ControllerBase
{
    [HttpGet]   
    public IActionResult Get([FromQuery] List<int> numbers, int min, int max)
    {
        var result = 
            from num in numbers
            where num >= min && num <= max
            select num;
        
        return Ok(result.ToList());
    }
}
