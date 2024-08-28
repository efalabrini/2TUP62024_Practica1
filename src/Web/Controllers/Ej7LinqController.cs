using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej7LinqController : ControllerBase {
    
    [HttpGet]
    
    public ActionResult Get([FromQuery]string phrase) {
        var words = phrase.Split(' ');
        var upperWords = words.Where(word => string.Equals(word, word.ToUpper(), StringComparison.Ordinal)).ToList();
    
    return Ok(upperWords);
    }
}