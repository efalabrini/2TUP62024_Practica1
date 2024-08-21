using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controllers : ControllerBase
    {
        [HttpGet]
        public string Get(string nombre, string ciudad)
        {
            return $"Hola {nombre}, bienvenido a {ciudad}";
        }
    }
}
