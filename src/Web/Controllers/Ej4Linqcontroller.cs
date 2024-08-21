using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej4Linqcontroller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery]List<int> numbers)
    {
        var numbersQuery = 
            (from num in numbers
            where num > 0
            orderby num descending
            select num).Take(5);
        return Ok(numbersQuery);
    }
}