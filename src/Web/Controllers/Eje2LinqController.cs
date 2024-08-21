using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Eje2Linqcontroller : ControllerBase
{

    [HttpGet]
    public ActionResult UpperWords([FromQuery]List<string> words)
    {
        var result = from word in words
                     where word.Length > 4
                     select word.ToUpper();

        return Ok(result);
       
    }
}
