using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class LinqEj4Controller: ControllerBase
{

    [HttpGet]

    public IActionResult Get([FromQuery] List<int> numbers)
    {
        var result = (from number in numbers
            orderby number descending
            select number).Take(5).ToList();

    return Ok(result);
    }



    
}