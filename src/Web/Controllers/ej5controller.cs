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
            if (string.IsNullOrWhiteSpace(dia))
            {
                return BadRequest("El parámetro 'dia' no puede estar vacío.");
            }

            string dia_format = dia.ToLower().Trim();

            if (dia_format == "sabado" || dia_format == "domingo")
            {
                string response = $"El dia {dia_format} es 'Fin de semana'";
                return StatusCode(200, response);
            }
            else
            {
                string response = $"El dia {dia_format} es 'Dia de semana'";
                return StatusCode(200, response);
            }
        }
    }
}
