using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEje6controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {
        var result = words.Select(x => x.Replace("ia", "*")).ToList();


        return Ok(result);
    }
}