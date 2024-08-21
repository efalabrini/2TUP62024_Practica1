using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj2Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<string> words)
    {
        var result =
            from word in words
            where word.Length >= 5
            select word.ToUpper();


        return Ok(result.ToList());
    }
}