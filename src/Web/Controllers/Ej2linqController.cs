using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;


[ApiController]
[Route("[controller]")]


public class Ej2linqController : ControllerBase {
    [HttpGet]
    public ActionResult Get([FromQuery]List<string> words) {
        var upperLongWords = words
            .Where(word => word.Length>=5)
            .Select(word =>word.ToUpper())
            .ToList();
        return Ok(upperLongWords);
    }
}