using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;


[ApiController]
[Route("[controller]")]


public class Ej6linqController : ControllerBase {
    [HttpGet]
    public ActionResult Get([FromQuery]List<string> words) {
        
        var iaWords = words.Select(x => x.Replace("ia","*")).ToList();

        return Ok(iaWords);
    }
}