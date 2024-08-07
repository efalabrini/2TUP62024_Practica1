using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej5Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string day)
        {
            string[] daysWeek = ["lunes", "martes", "miercoles", "jueves", "viernes"];
            string[] daysWeekend = ["sabado", "domingo"];

            day = day.ToLower().Trim();

            if (daysWeek.Contains(day))
            {
                return BadRequest("Ese dia NO pertenece al fin de semana");
            }
            else if (daysWeekend.Contains(day))
            {
                return Ok("Ese dia pertenece al fin de samana");
            }

            return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: El día ingresado no coincide con ningún día existente.");
        }
    }
}