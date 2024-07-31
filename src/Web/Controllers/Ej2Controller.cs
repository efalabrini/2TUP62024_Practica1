using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        [HttpGet]
        public string Get(string name, string city)
        {
            return $"Hola {name} bienvenido a {city} ";
        }
    }
}
