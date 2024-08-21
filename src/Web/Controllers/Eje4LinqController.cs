using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj4controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {
        var descendingOreder = numbers.OrderByDescending(x => x).ToList();
        int position = -1;
        var result =
           from number in descendingOreder
           where position < 4
           select descendingOreder[position = position + 1];


        return Ok(result.ToList());
    }
}