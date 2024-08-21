using System;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{
    [HttpGet("DiaSemana")]
    public IActionResult DiaSemana(string dia)
    {
        string[] diasDeLaSemana = {"lunes", "martes", "miércoles", "miercoles", "jueves", "viernes"};
        string[] finesDeSemana = {"sabado", "sábado", "domingo"};

        var diaN = dia.Trim().ToLowerInvariant();

        if (diasDeLaSemana.Contains(diaN))
        {
            return Ok("Es día de semana");
        }
        else if (finesDeSemana.Contains(diaN))
        {
            return Ok("Es fin de semana");
        }
        else {
            return StatusCode(500, "Se ha producido un error interno.");
        }
    }

}
