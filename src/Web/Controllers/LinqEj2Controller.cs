using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj2Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {
      
        var wordQuery = from word in words
                       where (word.Length >= 5)
                       select word.ToUpper();


        return Ok(wordQuery.ToList());
    }

}