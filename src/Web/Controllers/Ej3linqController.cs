using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;


[ApiController]
[Route("[controller]")]


public class Ej3linqController : ControllerBase {
    [HttpGet]
    public ActionResult Get([FromQuery]List<string> words) {
        var brWords = words.Where(word => word.StartsWith('b') && word.EndsWith('r')).ToList();
        return Ok(brWords);
    }
}