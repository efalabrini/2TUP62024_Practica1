using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj6controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<string> words)
    {
        string toReplace = "ia";
        var result = words.Where(x => x.Length > 0).Select(x => x.Replace(toReplace, "*")).ToList();
        return Ok(result);
    }
}