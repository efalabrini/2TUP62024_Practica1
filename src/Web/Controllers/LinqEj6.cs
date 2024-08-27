using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj6Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<string> Words)
   {
     var iaWord = (from Word in Words
                  select Word.Replace("ia", "*")).ToList();


    return Ok(iaWord);
    }

}
