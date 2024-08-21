using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj5Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<int> Numbers)
   {
     var result = (from number in Numbers
        let square = number * number
         where square > 20
         select $"{number} - {square}").ToList();

    return Ok(result);
    }

}
