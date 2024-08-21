using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;


//5) Reciba el nombre del día y retorne si es fin de semana o no. 
//En caso de error, debe retornar un status code del grupo de los 400 si es error del cliente
// o un status code del grupo de los 500 si es un error interno.
//Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” /        	“  lunes” 
//y debería funcionar

[ApiController]
[Route("[controller]")]


public class Ej5Controller : Controller
{
    [HttpGet]
    public ActionResult Get(string day)
    {
        string convertedDay = day.Trim().ToLower();

        string[] week = ["lunes", "martes", "miercoles", "jueves", "viernes"];
        string[] weekend = ["sabado", "domingo"];


        if (week.Contains(convertedDay))
        {
            return Ok("Es un día de semana");
        }
        else if (weekend.Contains(convertedDay))
        {
            return Ok("El dia ingresado pertenece al fn de semana");
        }
        else
        {
            return StatusCode(400, "Datos incorrectos");
        }
    }
