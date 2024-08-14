using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Eje5Controller : ControllerBase
{

    [HttpGet]
    public string Get(string dia)
    {
        string[] dias = ["lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo"];
        dia = dia.Trim().ToLower();
        for (int i = 0; i < dias.Length; i++) {
            if (dias[i] == dia) {
                if (i < 5) { 
                    return "El día que ingresó es un día de semana";
                }
                else { return "El día que ingresó es un día de fin de semana"; }
            }
                    
        }
        return "No se ha encontrado el día";
    }
            
}
    