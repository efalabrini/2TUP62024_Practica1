using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ej2controller : ControllerBase
    {
        public string Get(string nombre, string ciudad)
        {

            return $"Hola {nombre}, Bienvenido a {ciudad}";
        }

    }
}
