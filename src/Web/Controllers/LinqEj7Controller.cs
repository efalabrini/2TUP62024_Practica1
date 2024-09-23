
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class LinqEj7Controller : ControllerBase
{
    [HttpGet]

    public ActionResult Get([FromQuery] List<string> wordsList)
    {
        var words =
            from word in wordsList
            where word == word.ToUpper()
            select word;

        return Ok(words.ToList());
    }
}
