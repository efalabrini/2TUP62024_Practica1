using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej3Linqcontroller : ControllerBase
{
    [HttpGet]

    public IActionResult Get([FromQuery]List<string> words)
    {
        var wordQuery=
            from word in words
            where word.ToLower().StartsWith("b") && word.ToLower().EndsWith("r")
            select word;
        return Ok(wordQuery);
        
    }
}