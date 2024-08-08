using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;


[ApiController]
[Route("[controller]")]


public class Ej5Controller : ControllerBase {
    [HttpGet]
    public ActionResult Get(string day) {
        var week = new List<string> {"lunes", "martes", "miercoles", "jueves", "viernes"};
        var weekend = new List<string> {"sabado", "domingo"};

        if (week.Contains(day.ToLower().Trim())) 
            {return Ok("Es un dia de semana");}
        else if (weekend.Contains(day.ToLower().Trim()))
            {return Ok("Es fin de semana");}
        else
            {return StatusCode(400);}

        return StatusCode(500);

        
    }
    
}