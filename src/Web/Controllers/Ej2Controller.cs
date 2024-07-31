using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get([FromQuery]string nombre, [FromQuery] string ciudad)
        {
            string bienvenida = $"Hola {nombre}, bienvenido a la {ciudad}.";
            return bienvenida;
        }
    }
}
