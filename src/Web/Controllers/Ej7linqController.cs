using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;


[ApiController]
[Route("[controller]")]


public class Ej7linqController : ControllerBase {
    [HttpGet]
    public ActionResult Get([FromQuery]string phrase) {

        var words = phrase.Split(' ');
        var upperWords = words.Where(word => string.Equals(word, word.ToUpper(), StringComparison.Ordinal)).ToList();

        return Ok(upperWords);
    }
}