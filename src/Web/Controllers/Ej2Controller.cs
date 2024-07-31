using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej2Controller : Controller
    {
        [HttpGet]
        public IActionResult Get( string nombre, string ciudad)
        {
            string mensaje = $"Hola {nombre}, bienvenido a {ciudad}.";
            return Ok(mensaje);
        }
    }
}
