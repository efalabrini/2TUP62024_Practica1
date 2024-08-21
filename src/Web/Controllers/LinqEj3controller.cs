using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj3Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<string> words)
    {
        var result =
           from word in words
           where word[0] == 'b' && word[word.Length - 1] == 'r'
           select word;


        return Ok(result.ToList());
    }
}