using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej6Linqcontroller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery]List<string> words)
    {
        var wordsQuery = 
            from word in words
            where word.Contains("ia")  
            select word.Replace("ia", "*");

            return Ok(wordsQuery);
    }
}