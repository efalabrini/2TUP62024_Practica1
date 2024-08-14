//Pedir el nombre del día al usuario y decirle si es fin de semana o no.
//En caso de error, indicarlo. Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” /    
//“  lunes” y debería funcionar. TIP para investigar: Trim() y StringComparison.OrdinalIgnoreCase 

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej5Controller : ControllerBase
{
    [HttpGet]
    public string Get(string day)
    {
       day = day.Trim();

        if (day.Equals("sábado", StringComparison.OrdinalIgnoreCase) || 
                day.Equals("domingo", StringComparison.OrdinalIgnoreCase))
            {
                return $"{day} es un día de fin de semana.";
            }
            else if (day.Equals("lunes", StringComparison.OrdinalIgnoreCase) ||
                     day.Equals("martes", StringComparison.OrdinalIgnoreCase) ||
                     day.Equals("miércoles", StringComparison.OrdinalIgnoreCase) ||
                     day.Equals("jueves", StringComparison.OrdinalIgnoreCase) ||
                     day.Equals("viernes", StringComparison.OrdinalIgnoreCase))
            {
                return $"{day} es un día de semana.";
            }
            else
            {
                return "Día no válido.";
            }
    }
}