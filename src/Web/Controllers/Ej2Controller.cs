using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class Ej2Controller : Controller
    {
        [HttpGet]
        public string Get(string name, string city) {
            return $"Hola {name}, bienvenido a {city}";
        }
    }
}
