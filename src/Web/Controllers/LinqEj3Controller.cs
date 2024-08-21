using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj3Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {

        var wordQuery = from word in words
                        where (word[0] == 'b' && word[word.Length - 1] == 'r')
                        select word;

       
        return Ok(wordQuery.ToList());
    }

}