using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEje5controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {

        var result = numbers.Where(x => x * x> 20).Select(x => $"{x} - {x * x}").ToList();

        return Ok(result);
    }
}