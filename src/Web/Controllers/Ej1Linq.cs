using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej1Linq : ControllerBase
{
    [HttpGet]

    public ActionResult Get([FromQuery] List<int>numbers)
    {
        var numQuery = from number in numbers
                       where (number > 30 && number < 100)
                       select number;

        return Ok(numQuery.ToList());               

    }
}