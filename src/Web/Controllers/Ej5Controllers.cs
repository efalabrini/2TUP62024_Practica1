using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controllers : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(string day) 
        {
            var weekday = new List<string> {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            var weekend = new List<string> { "Sabado", "Domingo" };

            if (weekday.Contains(day.ToLower().Trim()))
            {
                return Ok("Es un dia de semana");
            }
            else if (weekend.Contains(day.ToLower().Trim()))
            {
                return Ok("Es fin de semana");
            }
            else
            {
                return Ok("ERROR. El dia ingresado no coincide");
            }
        }
    }
}
