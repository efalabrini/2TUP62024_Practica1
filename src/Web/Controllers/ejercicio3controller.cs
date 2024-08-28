using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ejercicio3controller : ControllerBase
    {

        [HttpGet]
        public string Get(string nombre, int edad)
        {

            return $"Hola {nombre}, tienes {edad} años";
        }

    }
}
