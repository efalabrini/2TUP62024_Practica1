using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej2Linqcontroller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery]List<string> words)
    {
        var wordQuery = 
            from word in words
            where word.Length > 4 
            select word.ToUpper(); 
        return Ok(wordQuery);
    }
}