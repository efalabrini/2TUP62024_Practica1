using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Eje5Controller : ControllerBase
{

    [HttpGet]
    public ActionResult Get(string day){
        day = day.Trim().ToLower();
        string[] week = ["lunes", "martes", "miercoles", "jueves", "viernes"];
        string[] weekend = ["sabado", "domingo"];

        if (week.Contains(day)) {
            return Ok("Es un día de semana");        
        }else if(weekend.Contains(day)){
            return Ok("Es fin de semana");
        }
        else{
            return StatusCode(400);
        }
        
    }
            
}
    