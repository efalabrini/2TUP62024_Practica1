using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj2Controller: ControllerBase
{
    [HttpGet]
public IActionResult Get([FromQuery] List<string>words)
{
    var filteredWords = from word in words
        where word.Length >=5  
        select word.ToUpper();
    return Ok(filteredWords.ToList());
}
}
