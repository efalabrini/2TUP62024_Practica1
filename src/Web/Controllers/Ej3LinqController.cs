using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej3linqController : ControllerBase {

    [HttpGet]
    public ActionResult Get([FromQuery]List<string> word) {

        var Words = word.Where(word => word.StartsWith('b') && word.EndsWith('r')).ToList();

        return Ok(Words);
    }
}