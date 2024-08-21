using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class LinqEj2Controller: ControllerBase
{

    [HttpGet]

    public IActionResult Get([FromQuery] List<string> Words)
    {
        var result = from words in Words
            where words.Length >=5
            select words.ToUpper();

        return Ok(result.ToList());



    }



    
}