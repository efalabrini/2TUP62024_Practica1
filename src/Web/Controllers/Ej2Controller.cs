using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetMensaje([FromQuery] string name, [FromQuery] string city)
        {
            return $"Hola {name} bienvenido a {city}.";
        }

    }
}
