using Microsoft.AspNetCore.Mvc;


namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej5Controller : Controller
{
    [HttpGet]
    public ActionResult Get(string day)
    {
        // if (string.IsNullOrWhiteSpace(dia))
        // {
        //     return BadRequest("El nombre del día no puede estar vacío");
        // }

        string diaConvertido = day.Trim().ToLower();

        string[] week = ["lunes", "martes", "miercoles", "jueves", "viernes"];
        string[] weekend = ["sabado", "domingo"];


        if (week.Contains(diaConvertido))
        {
            return Ok("Es día de semana");
        }
        else if (weekend.Contains(diaConvertido))
        {
            return Ok("Es fin de semana");
        }
        else
        {
            return StatusCode(400, "Datos incorrectos");
        }
    }
}