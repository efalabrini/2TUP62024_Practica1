using Microsoft.AspNetCore.Mvc;
using System.Linq;

[ApiController]
[Route("[controller]")]

public class Ej3Linq : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {
        var filteredWords = from word in words
                            where word.StartsWith("b") && word.EndsWith("r")
                            select word;

        return Ok(filteredWords);                    
    }
}