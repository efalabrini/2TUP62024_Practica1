using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj6Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {
        var result = words.Select(word => word.Replace("ia", "*")).ToList();
        return Ok(result);
    }
}