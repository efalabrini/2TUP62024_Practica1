using Microsoft.AspNetCore.Mvc;
using System;

namespace DiaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string dia)
        {
            if (string.IsNullOrWhiteSpace(dia))
            {
                return BadRequest("El nombre del día no puede estar vacío.");
            }

            string diaNormalizado = dia.Trim().ToLower();

            string[] semana = ["lunes", "martes", "miercoles", "jueves", "viernes"];
            string[] findesemana = ["sabado", "domingo"];

            try
            {
                if (semana.Contains(diaNormalizado))
                {
                    return Ok("No es fin de semana.");
                }
                else if (findesemana.Contains(diaNormalizado))
                {
                    return Ok("Es fin de semana.");
                }
                else
                {
                    throw new ArgumentException("El nombre del día no es válido.");
                }
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocurrió un error interno del servidor.");
            }
        }
    }
}
