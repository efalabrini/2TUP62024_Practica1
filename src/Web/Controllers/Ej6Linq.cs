using Microsoft.AspNetCore.Mvc;
using System.Linq;

[ApiController]
[Route("[controller]")]

public class Ej6Linq : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {
        var result = (from word in words
                     select word.Replace("ia", "*")).ToList(); 

        return Ok(result);                  
    }
}