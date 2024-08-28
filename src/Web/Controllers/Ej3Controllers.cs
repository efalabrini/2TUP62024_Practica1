using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controllers : ControllerBase
    {
        [HttpGet]
        public string Get(string nombre, int edad) 
        {
            return $"Mi nombre es {nombre} y tengo {edad} años"
        }
    }
}
