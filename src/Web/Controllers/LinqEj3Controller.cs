using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]


    public class LinqEj3Controller : ControllerBase
    {
    [HttpGet]    


           public ActionResult Get([FromQuery] List<string> wordList) 
           {
                var result = wordList.Where(x => x.StartsWith("b") && x.EndsWith("r")).Select(x => x);
                return Ok(result);
           }
    }

