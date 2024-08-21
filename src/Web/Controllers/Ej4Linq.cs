using Microsoft.AspNetCore.Mvc;
using System.Linq;

[ApiController]
[Route("[controller]")]

public class Ej4Linq : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {
        var sortedNumbers = (from number in numbers
                            orderby number descending
                            select number).Take(5);

        return Ok(sortedNumbers);                    
    }
}