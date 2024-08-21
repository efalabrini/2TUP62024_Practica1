using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string day)
        {
            day = day.ToLower().Trim();

            string[] week = ["lunes", "martes", "miercoles", "jueves", "viernes"];
            string[] weeknd = ["sabado", "domingo"];


            if (week.Contains(day))
            {
                return "Es un dia de semana";
            }
            else if (weeknd.Contains(day))
            {
                return "Es un dia del fin de semana";
            }

            return "El dia ingresado no existe";
        }
    }
}