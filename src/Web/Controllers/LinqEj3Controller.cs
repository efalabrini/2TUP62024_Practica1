using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class LinqEj3Controller: ControllerBase
{

    [HttpGet]

    public IActionResult Get([FromQuery] List<string> Words)
    {
       var result = from word in Words
            where word.Length > 0 && word[0] == 'b' && word[word.Length - 1] == 'r'
            select word.ToList();

    return Ok(result);
    }



    
}