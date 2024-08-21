using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj7controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get([FromQuery]string text)
    {
        string[] upperList = text.Split(" ");
        
        var result = upperList.Where(x => x.ToUpper() == x).ToList();

        return Ok(result);
    }
}
