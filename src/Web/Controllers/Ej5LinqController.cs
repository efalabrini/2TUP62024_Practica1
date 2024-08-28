using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej5LinqController : ControllerBase
{
     [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {
         var result = numbers.Where(x => x * x> 20).Select(x => $"{x} - {x * x}").ToList();

        return Ok(result);
    }
}