using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult EsFinDeSemana(string dia)
        {
            if (string.IsNullOrWhiteSpace(dia))
            {
                return BadRequest("El nombre del día no puede estar vacío.");
            }

            string diaNormalizado = dia.Trim().ToLower();

            switch (diaNormalizado)
            {
                case "sabado":
                case "sábado":
                case "domingo":
                    return Ok("Es fin de semana.");
                case "lunes":
                case "martes":
                case "miércoles":
                case "jueves":
                case "viernes":
                    return Ok("No es fin de semana.");
                default:
                    return NotFound("Día no válido.");
            }
        }
    }
}
