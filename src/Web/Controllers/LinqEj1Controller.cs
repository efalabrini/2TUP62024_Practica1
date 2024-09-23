using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;


[ApiController]
[Route("[controller]")]

public class LinqEj1Controller : ControllerBase
{
    [HttpGet]

    public ActionResult Get([FromQuery] List<int> list, int min, int max)
    {
        var numberList = (from x in list
                          where x >= min && x <= max
                          select x
                          )
                          .ToList();
        return Ok(numberList);
    }


}
