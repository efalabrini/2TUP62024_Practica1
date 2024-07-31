using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string dia)
        {
            dia = dia.ToLower().Trim();

            string[] semana = ["lunes", "martes", "miercoles", "jueves", "viernes"];
            string[] findesemana = ["sabado", "domingo"];


            if (semana.Contains(dia))
            {
                return "Es un dia de semana";
            }
            else if (findesemana.Contains(dia))
            {
                return "Es un dia del fin de semana";
            }

            return "El dia ingresado no existe";
        }
    }
}
