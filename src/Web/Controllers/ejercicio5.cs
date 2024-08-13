// 5) Reciba el nombre del día y retorne si es fin de semana o no. En caso de error, debe retornar un status code del grupo de los 400 si es error del cliente o un status code del grupo de los 500 si es un error interno.
// Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” /        	“  lunes” y debería funcionar


using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej5Controllers : ControllerBase
{

    [HttpGet]
    public ActionResult Get(string day)
    {
        var week = new List<string> {"lunes", "martes", "miercoles", "jueves", "viernes"};
        var weekend = new List<string> {"sabado", "domingo"};



        if(week.Contains(day.ToLower().Trim())){
            return Ok("Es dia de semana");
        } else if(weekend.Contains(day.ToLower().Trim())){
            return Ok("Es fin de semana");
        } else {
            return StatusCode(400);
        }
        
    }
}