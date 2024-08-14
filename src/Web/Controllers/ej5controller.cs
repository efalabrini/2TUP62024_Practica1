// Reciba el nombre del día y retorne si es fin de semana o no. En caso de error, debe retornar un status code del grupo de los 400 si es error del cliente o un status code del grupo de los 500 si es un error interno.
// Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” /        	“  lunes” y debería funcionar
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(string day)
    {
        if (string.IsNullOrWhiteSpace(day))
        {
            // Error del cliente: el día no fue proporcionado
            return BadRequest("El día no puede estar vacío.");
        }

        string lower = day.Trim().ToLower();

        if (lower == "domingo" || lower == "sábado" || lower == "sabado")
        {
            return Ok("Es fin de semana");
        }
        else if (lower == "lunes" || lower == "martes" || lower == "miércoles" || lower == "miercoles" || lower == "jueves" || lower == "viernes")
        {
            return Ok("Es día de semana");
        }
        else
        {
            // Error del cliente: el día proporcionado no es válido
            return BadRequest("El día proporcionado no es válido.");
        }
    }
}
