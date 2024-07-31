using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get([FromQuery] string nombre, [FromQuery] string anio)
        {
            string msj = $"Tu nombre es {nombre} y tienes {anio} años.";
            return msj;
        }
    }
}
