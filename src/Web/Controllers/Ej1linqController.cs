using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej1linqController : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> list, int min, int max)
    {
        var numberList = list.Where(x => x>=min && x<=max).ToList();
        return Ok(numberList);
    }
}
