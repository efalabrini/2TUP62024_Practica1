using System.Security.Principal;
using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(string day)
    {
        string minusDay = day.ToLower().Trim();
        List<string> week = ["lunes","martes","miercoles","jueves","viernes"];
        List<string> weekend = ["sabado","domingo"];

        if (week.Contains(minusDay)) {
            return Ok("No es fin de semana");
        } else if (weekend.Contains(minusDay)) {
            return Ok("Es fin de semana");
        } else {
            return StatusCode(400);
        }

        return StatusCode(500);
    }
}
