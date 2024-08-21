using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej2Linq : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {
        var stringQuery = from word in words
                          where word.Length >= 5
                          select word.ToUpper();

        return Ok(stringQuery);                  

    }
}