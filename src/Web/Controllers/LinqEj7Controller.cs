using System.IO.Compression;
using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj7Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {
        var result = words.Where(word => word.All(char.IsUpper)).ToList();
        return Ok(result);
    }
}
