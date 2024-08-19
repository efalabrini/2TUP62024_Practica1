using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string dia)
        {
            string[] diasSemana = { "lunes", "martes", "miercoles", "jueves", "viernes" };
            string[] finDeSemana = { "sabado", "domingo" };

            dia = dia.ToLower().Trim();
            
            if (Array.Exists(diasSemana, d => d == dia))
            {
                return Ok("Es dia de semana");
            }
            else if (Array.Exists(finDeSemana, d => d == dia))
            {
                return Ok("Es fin de semana");
            }
            else
            {
                return BadRequest("Se Ingreso una opcion no valida");
            }

        }
    }
}