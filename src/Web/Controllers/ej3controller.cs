using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej3Controller : ControllerBase
    {
        [HttpGet()]
        public string Get(string nombre, string anios)
        {
            string result = $"Te llamas {nombre} y tienes {anios} años";
            return result;
        }
    }
}