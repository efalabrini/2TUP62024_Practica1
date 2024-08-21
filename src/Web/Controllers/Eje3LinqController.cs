using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Eje3Linqcontroller : ControllerBase
{

    [HttpGet]
    public ActionResult get([FromQuery] List<string> words)
    {
        var result = from word in words
                     where word.StartsWith("b", StringComparison.OrdinalIgnoreCase) && word.EndsWith("r", StringComparison.OrdinalIgnoreCase)
                     select word;

        return Ok(result);

    }
}
