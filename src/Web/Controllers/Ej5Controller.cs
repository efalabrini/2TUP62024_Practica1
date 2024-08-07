using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] string day)
    {
        List<string> week = new List<string> { "lunes", "martes", "miercoles", "jueves", "viernes" };
        List<string> weekend = new List<string> { "sabado", "domingo" };
        string dayTrimToLower = day.Trim().ToLower();

       if (week.Contains(dayTrimToLower))
        {
            return Ok("Es un dia de semana");
        }
       else if (weekend.Contains(dayTrimToLower))
        {
            return Ok("Es fin de semana");
        }
       else
        {
            return NotFound("Dia no valido");
        }


    }
}

/*
 5) Reciba el nombre del día y retorne si es fin de semana o no. En caso
de error, debe retornar un status code del grupo de los 400 si es error
del cliente o un status code del grupo de los 500 si es un error interno.
Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / 
“lUnes” /        	“  lunes” y debería funcionar

 */