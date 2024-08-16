using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string dia)
        {
            try
            {
                dia = dia.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(dia))
                {
                    return BadRequest("El dia no puede estar vacio.");
                }

                if (dia == "sabado" || dia == "domingo")
                {
                    return Ok("Es fin de semana.");
                }
                else if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
                {
                    return Ok("No es fin de semana.");
                }
                else
                {
                    return BadRequest("Dia no valido.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
    }
}
