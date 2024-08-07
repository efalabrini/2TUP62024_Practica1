using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(string day)
    {
        if (string.IsNullOrEmpty(day))
        {
            return BadRequest("Es un día del finde semana");
        }

        day = day.Trim().ToLower();

        try
        {
            switch (day)
            {
                case "sabado":
                case "sábado":
                case "domingo":
                    return Ok("Es un día del fin de semana");
                case "lunes":
                case "martes":
                case "miércoles":
                case "miercoles":
                case "jueves":
                case "viernes":
                    return Ok("No es un día del fin de semana");
                default:
                    return BadRequest("El día proporcionado no es válido.");
            }
        }
        catch (Exception)
        {
            return StatusCode(500, "Ocurrió un error interno.");
        }
    }
}
