using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]

[Route("[controller]")]

public class Ejercicio5 : ControllerBase{


    [HttpGet]

    public ActionResult Get(string day)
     {
        if (day.ToLower().Trim() == "sabado" || day.ToLower().Trim() =="domingo"){
            return Ok("Es fin de semana");
        }else if (day.ToLower().Trim() == "lunes" || day.ToLower().Trim() =="martes" || day.ToLower().Trim() == "miercoles" || day.ToLower().Trim() =="jueves" || day.ToLower().Trim() =="viernes"){
            return Ok("No es fin de semana");
        }else {return StatusCode(400);}
        
    }

    
}