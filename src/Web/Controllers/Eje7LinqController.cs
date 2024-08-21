using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEje7controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] string word)
    {
        string[] words = word.Split(' ');
        var result = words.Where(x => x == x.ToUpper()).Select(x => x).ToList();
        return Ok(result);
    }
}