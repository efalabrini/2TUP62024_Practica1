using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj1Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get([FromQuery] List<int>numbers, int min, int max ){
       var filteredNumbers=from number in numbers
            where number >= min && number <= max
            select number;

        return Ok(filteredNumbers.ToList());
    }
}
