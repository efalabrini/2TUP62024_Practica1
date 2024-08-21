using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj3Controller: ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery]List<string>words){
        var filteredWords=words.Where(x=>x.StartsWith("b") && x.EndsWith("r")).Select(x=>x);
        return Ok(filteredWords);
    }
}
