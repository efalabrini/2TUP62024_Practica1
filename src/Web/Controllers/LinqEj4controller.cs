using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj4controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<int> numbers)
    {
        int position = 0;
        var result =
           from number in numbers
           where position < 5
           select numbers[position];
        position++;

        return Ok(result.ToList());
    }
}